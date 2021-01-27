using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

//SharpDX
using SharpDX.D3DCompiler;
using SharpDX.Direct3D;
using SharpDX.DXGI;
using SharpDX.Windows;
using SharpDX;
using D3D11 = SharpDX.Direct3D11;


namespace EDSphere
{
    class DXWindow : IDisposable
    {
        public DataTable dt;
        private int windowW;
        private int windowH;

        //SharpDX
        private RenderForm renderForm;
        private D3D11.Device d3dDevice;
        private D3D11.DeviceContext d3dDeviceContext;
        private SwapChain swapChain;
        private D3D11.RenderTargetView renderTargetView;
        private Viewport viewport;

        // Shaders
        private D3D11.VertexShader vertexShader;
        private D3D11.PixelShader pixelShader;
        private ShaderSignature inputSignature;
        private D3D11.InputLayout inputLayout;

        private D3D11.InputElement[] inputElements = new D3D11.InputElement[]
        {
            new D3D11.InputElement("POSITION", 0, Format.R32G32B32_Float, 0)
        };

        private string[] vertexSaderProgramms = new string[10];
        private string[] pixelSaderProgramms = new string[10];
        // Triangle vertices
        private Vector3[] vertices = new Vector3[] { new Vector3(-0.5f, 0.5f, 0.0f),
            new Vector3(0.5f, 0.5f, 0.0f), new Vector3(0.0f, -0.5f, 0.0f) };
        private D3D11.Buffer triangleVertexBuffer;
        

        public DXWindow(string name = "DirectX", int w = 1200, int h = 720)
        {
            windowW = w;
            windowH = h;

            renderForm = new RenderForm(name);
            renderForm.ClientSize = new Size(windowW, windowH);
            
            renderForm.AllowUserResizing = false; //!!!!!!!!!!

            InitializeProgramms();

            InitializeDeviceResources();
            InitializeShaders();
            InitializeTriangle();
  
        }

        public void Dispose()
        {
            inputLayout.Dispose();
            inputSignature.Dispose();
            triangleVertexBuffer.Dispose();
            vertexShader.Dispose();
            pixelShader.Dispose();
            renderTargetView.Dispose();
            swapChain.Dispose();
            d3dDevice.Dispose();
            d3dDeviceContext.Dispose();
            renderForm.Dispose();
        }

        public void Run()
        {
            RenderLoop.Run(renderForm, RenderCallback);
        }

        private void RenderCallback()
        {
            Draw();
        }

        private void InitializeDeviceResources()
        {
            //create a description for our back buffer
            /// The first 2 parameters are the size of the back buffer,
            /// which in most cases should match the client width/height
            /// of the window we are rendering in.
            /// The third parameter is the refresh rate in Hz (hertz),
            /// we set this to 60/1 = 60 Hz.
            /// The last parameter is the format of the back buffer,
            /// here we specify a format with a red, green, blue, and alpha channel
            /// using 32-bit unsigned integer.
            ///
            ModeDescription backBufferDesc = 
                new ModeDescription(windowW, windowH, new Rational(60, 1),
                                    Format.R8G8B8A8_UNorm);
            //create a descriptor for our swap chain
            ///ModeDescription: Here we provide our back buffer description.
            ///SampleDescription: This is a descriptor for multisampling,
            ///we just specify one level(no multisampling) See DXGI_SAMPLE_DESC on MSDN.
            ///Usage: Specify if/ how the CPU can access the back buffer,
            ///as we are rendering to it we specify it as RenderTargetOutput.
            ///For other options see MSDN for DXGI_USAGE.
            ///OutputHandle: Handle to the window to render in.
            ///BufferCount: Number of buffers, we just need 1.
            ///IsWindowed: Wheather we want to be in fullscreen or windowed mode.
            ///
            SwapChainDescription swapChainDesc = new SwapChainDescription()
            {
                ModeDescription = backBufferDesc,
                SampleDescription = new SampleDescription(1, 0),
                Usage = Usage.RenderTargetOutput,
                BufferCount = 1,
                OutputHandle = renderForm.Handle,
                IsWindowed = true
            };
            // create our device and swap chain
            ///The first parameter specifies that we want to use the GPU.
            ///We choose to not use any special flags,
            ///for possible flags see D3D11_CREATE_DEVICE_FLAG on MSDN.
            ///Third parameter is our swap chain descriptor.
            ///The last parameters are in which variables we want to store
            ///our swap chain and device in.
            ///
            D3D11.Device.CreateWithSwapChain(DriverType.Hardware, D3D11.DeviceCreationFlags.None, swapChainDesc, out d3dDevice, out swapChain);
            d3dDeviceContext = d3dDevice.ImmediateContext;

            // Set viewport
            viewport = new Viewport(0, 0, windowW, windowH);
            d3dDeviceContext.Rasterizer.SetViewport(viewport);

            //create a back buffer which we can render to
            using (D3D11.Texture2D backBuffer = swapChain.GetBackBuffer<D3D11.Texture2D>(0))
            {
                renderTargetView = new D3D11.RenderTargetView(d3dDevice, backBuffer);
            }
        }

        private void InitializeTriangle()
        {
            triangleVertexBuffer = D3D11.Buffer.Create<Vector3>(d3dDevice, D3D11.BindFlags.VertexBuffer, vertices);
        }

        private void InitializeProgramms()
        {
            vertexSaderProgramms[0] = @"float4 main(float4 position : POSITION) : SV_POSITION
                                        {
                                           return position;
                                        }";
            pixelSaderProgramms[0] = @"float4 main(float4 position : SV_POSITION) : SV_TARGET
                                        {
                                           return float4(1.0, 0.0, 0.0, 1.0);
                                        }";
        }

        private void InitializeShaders()
        {
            //using (var vertexShaderByteCode = ShaderBytecode.CompileFromFile("vertexShader.hlsl", "main", "vs_4_0", ShaderFlags.Debug))
            using (var vertexShaderByteCode = ShaderBytecode.Compile(vertexSaderProgramms[0], "main", "vs_4_0", ShaderFlags.Debug))
            {
                // Read input signature from shader code
                inputSignature = ShaderSignature.GetInputSignature(vertexShaderByteCode);

                vertexShader = new D3D11.VertexShader(d3dDevice, vertexShaderByteCode);
            }
           //using (var pixelShaderByteCode = ShaderBytecode.CompileFromFile("pixelShader.hlsl", "main", "ps_4_0", ShaderFlags.Debug))
            using (var pixelShaderByteCode = ShaderBytecode.Compile(pixelSaderProgramms[0], "main", "ps_4_0", ShaderFlags.Debug))
            {
                pixelShader = new D3D11.PixelShader(d3dDevice, pixelShaderByteCode);
            }
            // Set as current vertex and pixel shaders
            d3dDeviceContext.VertexShader.Set(vertexShader);
            d3dDeviceContext.PixelShader.Set(pixelShader);

            d3dDeviceContext.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleList;

            // Create the input layout from the input signature and the input elements
            inputLayout = new D3D11.InputLayout(d3dDevice, inputSignature, inputElements);

            // Set input layout to use
            d3dDeviceContext.InputAssembler.InputLayout = inputLayout;
        }

        private void Draw()
        {
            // Set back buffer as current render target view
            d3dDeviceContext.OutputMerger.SetRenderTargets(renderTargetView);

            // Clear the screen
            d3dDeviceContext.ClearRenderTargetView(renderTargetView,
                new SharpDX.Color(0, 0, 0)); //new SharpDX.Color(32, 103, 178));

            // Set vertex buffer
            d3dDeviceContext.InputAssembler.SetVertexBuffers(0,
                new D3D11.VertexBufferBinding(triangleVertexBuffer,
                Utilities.SizeOf<Vector3>(), 0));

            // Draw the triangle
            d3dDeviceContext.Draw(vertices.Count(), 0);


            // Swap front and back buffer
            swapChain.Present(1, PresentFlags.None);
        }
    }
}
