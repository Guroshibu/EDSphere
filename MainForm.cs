using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization.Charting;

namespace EDSphere
{
    public partial class MainForm : Form
    {
        private DataTable dt;
        private DataColumn dtc;

        private DataTable dtRoute;
        private DataTable dtCoords;

        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter adapter;

        bool load;

        public MainForm()
        {
            InitializeComponent();

            dt = new DataTable();
            dgvResult.AutoGenerateColumns = false;

            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "System",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "CenterDistance",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "CurrentDistance",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "X",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Y",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Z",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Angle",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dt.Columns.Add(dtc);
            dgvResult.DataSource = dt;

            dtRoute = new DataTable();
            dgvRoute.AutoGenerateColumns = false;

            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = "ID",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = "Point",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "System",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "X",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Y",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Z",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = "Passed",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtRoute.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Comment",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dgvRoute.DataSource = dtRoute;

            dtCoords = new DataTable();
            dgvCoords.AutoGenerateColumns = false;

            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = "ID",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "X",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Y",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Z",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "System",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "SX",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "SY",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);
            dtc = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "SZ",
                AutoIncrement = false,
                Caption = "",
                ReadOnly = false,
                Unique = false
            };
            dtCoords.Columns.Add(dtc);

            dgvCoords.DataSource = dtCoords;

            nudChartSearchAngleX.Value =
                chartSearch.ChartAreas["SearchChartArea"].Area3DStyle.Inclination;
            nudChartSearchAngleY.Value =
                chartSearch.ChartAreas["SearchChartArea"].Area3DStyle.Rotation;
            nudChartRouteAngleX.Value =
                chartRoute.ChartAreas["RouteChartArea"].Area3DStyle.Inclination;
            nudChartRouteAngleY.Value =
                chartRoute.ChartAreas["RouteChartArea"].Area3DStyle.Rotation;

        }

        private bool KeyCheck(char key, string value)
        {
            if (char.IsDigit(key)) return true;
            if(key == 8) return true; //backspace
            if (key == 127) return true; //delete
            if (key == '.' && value.IndexOf(".") == -1 && value.IndexOf(",") == -1) return true;
            if (key == ',' && value.IndexOf(".") == -1 && value.IndexOf(",") == -1) return true;

            return false;
        }

        private string SetMinus(string value)
        {
            if(value[0] == '-')
            {
                value = value.Substring(1);
            }
            else
            {
                value = "-" + value;
            }

            return value;
        }

        private double angle(double x1, double y1, double x2, double y2)
        {
            double t = (x1 * x2 + y1 * y2) / (Math.Sqrt((double)x1 * x1 + y1 * y1) * Math.Sqrt((double)x2 * x2 + y2 * y2));
            if (t < -1) t = -1;
            else if (t > 1) t = 1;
            return Math.Acos(t);
        }

        private Star GetNearestStar(double x, double y, double z)
        {
            Star star = new Star();
            HttpWebResponse response;
            StarSystems result = new StarSystems();
            DataTable sys = dt.Clone();
            sys.Clear();

            string edsmRequest = "https://www.edsm.net/api-v1/sphere-systems?";
            edsmRequest = edsmRequest + "x=" + x + "&";
            edsmRequest = edsmRequest + "y=" + y + "&";
            edsmRequest = edsmRequest + "z=" + z + "&";
            edsmRequest = edsmRequest + "minRadius=" + "0" + "&";
            edsmRequest = edsmRequest + "radius=" + "50" + "&";
            edsmRequest = edsmRequest + "showCoordinates=1";
            WebRequest request = WebRequest.Create(edsmRequest);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = 300000;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                return star;
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                if (responseFromServer == "[]" || responseFromServer == "{}") return star;

                result.Systems = JsonConvert.DeserializeObject<List<StarSystem>>(responseFromServer);
                foreach (StarSystem system in result.Systems)
                {
                    if (system.coords.x == null ||
                        system.coords.y == null ||
                        system.coords.z == null) continue;

                    DataRow row = sys.NewRow();

                    row["System"] = system.name;
                    row["CenterDistance"] = 0;
                    row["CurrentDistance"] = system.distance;
                    row["X"] = system.coords.x;
                    row["Y"] = system.coords.y;
                    row["Z"] = system.coords.z;

                    sys.Rows.Add(row);
                }
                //DataView dataView = new DataView(sys);
                //dataView.Sort = "CurrentDistance ASC";
                sys.DefaultView.Sort = "CurrentDistance ASC";
                sys = sys.DefaultView.ToTable();

                star.name = sys.Rows[0]["System"].ToString();
                star.xs = Convert.ToDouble(sys.Rows[0]["X"]);
                star.ys = Convert.ToDouble(sys.Rows[0]["Y"]);
                star.zs = Convert.ToDouble(sys.Rows[0]["Z"]);
            }
            response.Close();
            return star;
        }
        //events

        private void tbxCenterX_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if(e.KeyChar == '-')
            {
                this.tbxCenterX.Text = SetMinus(this.tbxCenterX.Text);
            }
            if (KeyCheck(e.KeyChar, this.tbxCenterX.Text))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            double dx = 0;
            double dy = 0;
            double dz = 0;
            int distance = 0;
            double angle;

            HttpWebResponse response;

            StarSystems result = new StarSystems();
            double centerX = Double.Parse(this.tbxCenterX.Text);
            double centerY = Double.Parse(this.tbxCenterY.Text);
            double centerZ = Double.Parse(this.tbxCenterZ.Text);
            double centerR = Double.Parse(this.tbxCenterRadius.Text);

            double currentX = Double.Parse(this.tbxCurrentX.Text);
            double currentY = Double.Parse(this.tbxCurrentY.Text);
            double currentZ = Double.Parse(this.tbxCurrentZ.Text);
            double currentR = Double.Parse(this.tbxCurrentRadius.Text);

            double span = Double.Parse(this.tbxSpan.Text);

            this.tbxResult.ForeColor = Color.Black;

            int crMin = (int)(centerR - span);
            int crMax = (int)(centerR + span);

            if (crMin < 0) crMin = 0;
            if (currentR < 0) currentR = 0;
            if (currentR > 100) currentR = 100;

            string edsmRequest = "https://www.edsm.net/api-v1/sphere-systems?";
            edsmRequest = edsmRequest + "x=" + currentX.ToString() + "&";
            edsmRequest = edsmRequest + "y=" + currentY.ToString() + "&";
            edsmRequest = edsmRequest + "z=" + currentZ.ToString() + "&";
            edsmRequest = edsmRequest + "minRadius=" + "0" + "&";
            edsmRequest = edsmRequest + "radius=" + currentR.ToString() + "&";
            edsmRequest = edsmRequest + "showCoordinates=1";

            this.tbxResult.Text = "Отправка запроса в EDSM";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(edsmRequest);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = 300000;
            try {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex){
                response = null;
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = "Error: " + response.StatusDescription;
                response.Close();
                return;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            if (responseFromServer == "[]" || responseFromServer == "{}")
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = "Систем в базе EDSM не найдено";
                return;
            }

            result.Systems = JsonConvert.DeserializeObject<List<StarSystem>>(responseFromServer);

            this.tbxResult.Text = "Ответ получен. Найдено " + result.Systems.Count.ToString() + " систем";
            Application.DoEvents();

            dt.Clear();
            foreach (StarSystem system in result.Systems)
            {
                if (system.coords.x == null ||
                    system.coords.y == null ||
                    system.coords.z == null) continue;

                dx = centerX - (double)system.coords.x;
                dy = centerY - (double)system.coords.y;
                dz = centerZ - (double)system.coords.z;

                distance = (int)Math.Sqrt(dx * dx + dy * dy + dz * dz);
                if (distance <= crMin || distance >= crMax) continue;

                DataRow row = dt.NewRow();
               
                row["System"] = system.name;
                row["CenterDistance"] = distance;
                row["CurrentDistance"] = system.distance;
                row["X"] = system.coords.x;
                row["Y"] = system.coords.y;
                row["Z"] = system.coords.z;

                dx = (double)system.coords.x - currentX;
                dz = (double)system.coords.z - currentZ;

                angle = this.angle(0, 1, dx, dz);
                row["Angle"] = Math.Round(angle * 180 / Math.PI, 1);

                dt.Rows.Add(row);
            }

        }

        private void btnCenterCoordinates_Click(object sender, EventArgs e)
        {
            HttpWebResponse response;
            StarSystemCoords result = new StarSystemCoords();

            this.tbxResult.ForeColor = Color.Black;

            string edsmRequest = "https://www.edsm.net/api-v1/system?";
            edsmRequest = edsmRequest + "systemName=" + this.tbxCenterSystem.Text + "&";
            edsmRequest = edsmRequest + "showCoordinates=1";

            this.tbxResult.Text = "Отправка запроса в EDSM";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(edsmRequest);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = 300000;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                response = null;
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = "Error: " + response.StatusDescription;
                response.Close();
                return;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            if(responseFromServer == "[]" || responseFromServer == "{}")
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = "Система в базе EDSM не найдена";
                return;
            }
            result = JsonConvert.DeserializeObject<StarSystemCoords>(responseFromServer);

            this.tbxResult.Text = "Ответ получен";

            this.tbxCenterX.Text = result.coords.x.ToString();
            this.tbxCenterY.Text = result.coords.y.ToString();
            this.tbxCenterZ.Text = result.coords.z.ToString();
        }

        private void btnCurrentCoordinates_Click(object sender, EventArgs e)
        {
            HttpWebResponse response;
            StarSystemCoords result = new StarSystemCoords();

            this.tbxResult.ForeColor = Color.Black;

            string edsmRequest = "https://www.edsm.net/api-v1/system?";
            edsmRequest = edsmRequest + "systemName=" + this.tbxCurrentSystem.Text + "&";
            edsmRequest = edsmRequest + "showCoordinates=1";

            this.tbxResult.Text = "Отправка запроса в EDSM";
            Application.DoEvents();

            WebRequest request = WebRequest.Create(edsmRequest);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = 300000;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                response = null;
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = "Error: " + response.StatusDescription;
                response.Close();
                return;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            if (responseFromServer == "[]" || responseFromServer == "{}")
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = "Система в базе EDSM не найдена";
                return;
            }
            result = JsonConvert.DeserializeObject<StarSystemCoords>(responseFromServer);

            this.tbxResult.Text = "Ответ получен";

            this.tbxCurrentX.Text = result.coords.x.ToString();
            this.tbxCurrentY.Text = result.coords.y.ToString();
            this.tbxCurrentZ.Text = result.coords.z.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.lblFrom.Text = Properties.Settings.Default.From;
            this.lblTo.Text = Properties.Settings.Default.To;

            this.tbxCenterSystem.Text = Properties.Settings.Default.CenterSystem;
            this.tbxCenterX.Text = Properties.Settings.Default.CenterX;
            this.tbxCenterY.Text = Properties.Settings.Default.CenterY;
            this.tbxCenterZ.Text = Properties.Settings.Default.CenterZ;
            this.tbxCenterRadius.Text = Properties.Settings.Default.CenterR;
            this.tbxCurrentSystem.Text = Properties.Settings.Default.CurrertSystem;
            this.tbxCurrentX.Text = Properties.Settings.Default.CurrentX;
            this.tbxCurrentY.Text = Properties.Settings.Default.CurrentY;
            this.tbxCurrentZ.Text = Properties.Settings.Default.CurrentZ;
            this.tbxCurrentRadius.Text = Properties.Settings.Default.CurrentR;
            try
            {
                conn = new SQLiteConnection("Data Source=db.sqlite3;Version=3;");
                conn.Open();
                cmd = new SQLiteCommand();
                cmd.Connection = conn;
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }
            load = true;
            cmd.CommandText = @"SELECT * FROM Route";
            try
            {
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dtRoute);
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }
            //dgvRoute.DataSource = dtRoute;
            dgvRoute.Sort(dgvRoute.Columns["dgvRoutePoint"], ListSortDirection.Ascending);
            dgvRoute.Update();
            load = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.From = this.lblFrom.Text;
            Properties.Settings.Default.To = this.lblTo.Text;

            Properties.Settings.Default.CenterSystem = this.tbxCenterSystem.Text;
            Properties.Settings.Default.CenterX = this.tbxCenterX.Text;
            Properties.Settings.Default.CenterY = this.tbxCenterY.Text;
            Properties.Settings.Default.CenterZ = this.tbxCenterZ.Text;
            Properties.Settings.Default.CenterR = this.tbxCenterRadius.Text;
            Properties.Settings.Default.CurrertSystem = this.tbxCurrentSystem.Text;
            Properties.Settings.Default.CurrentX = this.tbxCurrentX.Text;
            Properties.Settings.Default.CurrentY = this.tbxCurrentY.Text;
            Properties.Settings.Default.CurrentZ = this.tbxCurrentZ.Text;
            Properties.Settings.Default.CurrentR = this.tbxCurrentRadius.Text;
            Properties.Settings.Default.Save();
            try
            {
                conn.Close();
                conn.Dispose();
            }
            catch { };
        }

        private void SearchAddToRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = dtRoute.NewRow();
            int max;

            max = Convert.ToInt32(dtRoute.AsEnumerable()
                        .Max(drow => drow["ID"]));
            row["ID"] = ++max;

            max = Convert.ToInt32(dtRoute.AsEnumerable()
                        .Max(drow => drow["Point"]));
            row["Point"] = ++max;
            row["System"] = dgvResult.CurrentRow.Cells["dgvcSystem"].Value;
            row["X"] = dgvResult.CurrentRow.Cells["dgvcX"].Value;
            row["Y"] = dgvResult.CurrentRow.Cells["dgvcY"].Value;
            row["Z"] = dgvResult.CurrentRow.Cells["dgvcZ"].Value;
            row["Passed"] = 0;
            row["Comment"] = "";
            dtRoute.Rows.Add(row);

            //
            cmd.CommandText = @"INSERT INTO Route (ID, Point, System, X, Y, Z, Passed, Comment)
                                       VALUES (@ID, @Point, @System, @X, @Y, @Z, @Passed, @Comment)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", DbType.Int32).Value = row["ID"];
            cmd.Parameters.Add("@Point", DbType.Int32).Value = row["Point"];
            cmd.Parameters.Add("@System", DbType.String).Value = row["System"];
            cmd.Parameters.Add("@X", DbType.Double).Value = row["X"];
            cmd.Parameters.Add("@Y", DbType.Double).Value = row["Y"];
            cmd.Parameters.Add("@Z", DbType.Double).Value = row["Z"];
            cmd.Parameters.Add("@Passed", DbType.Int32).Value = row["Passed"];
            cmd.Parameters.Add("@Comment", DbType.String).Value = row["Comment"];

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            this.tabControl.SelectTab("tabPageRoute");
        }

        private void RouteSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoute.CurrentRow == null) return;
            cmd.CommandText = @"UPDATE Route
                                SET Point = @Point,
                                    Passed = @Passed,
                                    Comment = @Comment
                                WHERE ID = @ID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", DbType.Int32).Value =
                Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRouteID"].Value);
            cmd.Parameters.Add("@Point", DbType.Int32).Value =
                Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRoutePoint"].Value);
            cmd.Parameters.Add("@Passed", DbType.Int32).Value =
                Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRoutePassed"].Value);
            cmd.Parameters.Add("@Comment", DbType.String).Value =
                Convert.ToString(dgvRoute.CurrentRow.Cells["dgvRouteComment"].Value);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }
        }

        private void RouteDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoute.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRouteID"].Value);

            cmd.CommandText = @"DELETE FROM Route WHERE ID = @ID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", DbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            DataRow row = dtRoute.Select("ID = " + id.ToString())[0];
            dtRoute.Rows.Remove(row);
            dgvRoute.Update();

        }

        private void Search3DShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series series;
            Star star;
            string text;

            //Ось Z это количество рядов диаграммы
            //1 ряд = 1 св. году
            //подготоака массива данных
            Dictionary<int, List<Star>> chRows = new Dictionary<int, List<Star>>();
            List<Star> stars; 
            //
            foreach (DataRow row in dt.Rows)
            {
                star = new Star();
                star.name = row["System"].ToString();
                star.x = Convert.ToInt32(row["X"]);
                star.y = Convert.ToInt32(row["Y"]);
                star.z = Convert.ToInt32(row["Z"]);
                star.xs = Convert.ToDouble(row["X"]);
                star.ys = Convert.ToDouble(row["Y"]);
                star.zs = Convert.ToDouble(row["Z"]);
                if(star.name == tbxCurrentSystem.Text)
                {
                    star.isCurrent = true;
                }

                if (chRows.ContainsKey(star.z))
                {
                    chRows[star.z].Add(star);
                }
                else
                {
                    stars = new List<Star>();
                    stars.Add(star);
                    chRows.Add(star.z, stars);
                }
            }
            //количество рядов
            int maxz = Convert.ToInt32(dt.AsEnumerable().Max(drow => drow["Z"]));
            int minz = Convert.ToInt32(dt.AsEnumerable().Min(drow => drow["Z"]));
            int chRowCount = maxz - minz;
            //количество точек в ряду
            int maxx = Convert.ToInt32(dt.AsEnumerable().Max(drow => drow["X"]));
            int minx = Convert.ToInt32(dt.AsEnumerable().Min(drow => drow["X"]));

            int indx;
            //int indy;
            int keyz;

            chartSearch.Series.Clear();
            //Отметка -Z
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.MarkerStyle = MarkerStyle.Triangle;
            series.MarkerSize = 10;
            series.Color = Color.Black;
            series.Points.AddXY(0, 0);
            series.Points[0].Color = Color.Red;
            series.Points[0].Label = "-Z";
            series.Points[0].LabelForeColor = Color.White;

            chartSearch.Series.Add(series);
            //звезды
            for (int i = 0; i < chRowCount; i++)
            {
                series = new Series();
                series.ChartType = SeriesChartType.Point;
                series.MarkerStyle = MarkerStyle.Star6;
                series.MarkerSize = 10;
                series.Color = Color.Black;

                keyz = minz + i;
                if (chRows.ContainsKey(keyz))
                {
                    foreach(Star s in chRows[keyz])
                    {
                        indx = s.x - minx;
                        series.Points.AddXY(indx, s.y);
                        series.Points[series.Points.Count - 1].Color = Color.White;
                        series.Points[series.Points.Count - 1].Label = s.name;
                        series.Points[series.Points.Count - 1].LabelForeColor = Color.White;
                        if (s.isCurrent)
                        {
                            series.Points[series.Points.Count - 1].Color = Color.Yellow;
                            series.Points[series.Points.Count - 1].LabelBorderColor = Color.White;
                            series.Points[series.Points.Count - 1].LabelBorderDashStyle =
                                ChartDashStyle.Solid;
                            series.Points[series.Points.Count - 1].LabelBorderWidth = 1;
                        }
                        text = s.name + "\n" +
                            "X: " + s.xs.ToString() + "\n" +
                            "Y: " + s.ys.ToString() + "\n" +
                            "Z: " + s.zs.ToString();
                        series.Points[series.Points.Count - 1].ToolTip = text;
                    }
                }
                else
                {
                    series.Points.AddXY(0, 0);
                }
                chartSearch.Series.Add(series);
            }
            //Отметка +Z
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.MarkerStyle = MarkerStyle.Triangle;
            series.MarkerSize = 10;
            series.Color = Color.Black;
            series.Points.AddXY(0, 0);
            series.Points[0].Color = Color.Green;
            series.Points[0].Label = "+Z";
            series.Points[0].LabelForeColor = Color.White;

            chartSearch.Series.Add(series);
        }
                
        private void nudChartSearchAngleX_ValueChanged(object sender, EventArgs e)
        {
            chartSearch.ChartAreas["SearchChartArea"].Area3DStyle.Inclination =
                (int)nudChartSearchAngleX.Value;
        }

        private void nudChartSearchAngleY_ValueChanged(object sender, EventArgs e)
        {
            chartSearch.ChartAreas["SearchChartArea"].Area3DStyle.Rotation =
                (int)nudChartSearchAngleY.Value;
        }

        private void chartSearch_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result;
            string name = "";
            if(e.Button == MouseButtons.Left)
            {
                result = chartSearch.HitTest(e.X, e.Y, ChartElementType.DataPoint);
                if(result.Object != null)
                    name = result.Series.Points[result.PointIndex].Label;
                tbxSearchChartSelecned.Text = name;
            }
        }

        private void btnSeriseChartAddToRoute_Click(object sender, EventArgs e)
        {
            string sysname = tbxSearchChartSelecned.Text.Replace("'", "''");
            DataRow[] rows = dt.Select("System = '" + sysname + "'");
            if (rows.Count<DataRow>() == 0) return;

            DataRow row = dtRoute.NewRow();
            int max;

            max = Convert.ToInt32(dtRoute.AsEnumerable()
                        .Max(drow => drow["ID"]));
            row["ID"] = ++max;

            max = Convert.ToInt32(dtRoute.AsEnumerable()
                        .Max(drow => drow["Point"]));
            row["Point"] = ++max;
            row["System"] = rows[0]["System"];
            row["X"] = rows[0]["X"];
            row["Y"] = rows[0]["Y"];
            row["Z"] = rows[0]["Z"];
            row["Passed"] = 0;
            row["Comment"] = "";
            dtRoute.Rows.Add(row);

            //
            cmd.CommandText = @"INSERT INTO Route (ID, Point, System, X, Y, Z, Passed, Comment)
                                       VALUES (@ID, @Point, @System, @X, @Y, @Z, @Passed, @Comment)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", DbType.Int32).Value = row["ID"];
            cmd.Parameters.Add("@Point", DbType.Int32).Value = row["Point"];
            cmd.Parameters.Add("@System", DbType.String).Value = row["System"];
            cmd.Parameters.Add("@X", DbType.Double).Value = row["X"];
            cmd.Parameters.Add("@Y", DbType.Double).Value = row["Y"];
            cmd.Parameters.Add("@Z", DbType.Double).Value = row["Z"];
            cmd.Parameters.Add("@Passed", DbType.Int32).Value = row["Passed"];
            cmd.Parameters.Add("@Comment", DbType.String).Value = row["Comment"];

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            this.tabControl.SelectTab("tabPageRoute");
        }

        private void Route3DShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series series;
            Star star;
            string text;

            int maxz = 0;
            int minz = 0;
            int maxx = 0;
            int minx = 0;
            //Ось Z это количество рядов диаграммы

            //подготоака массива данных
            Dictionary<int, List<Star>> chRows = new Dictionary<int, List<Star>>();
            List<Star> stars;
            int jump = Convert.ToInt32(tbxChartRouteJump.Text);
            //
            foreach (DataRow row in dtRoute.Rows)
            {
                star = new Star();
                star.name = row["System"].ToString();
                star.x = Convert.ToInt32(row["X"]) / jump;
                star.y = Convert.ToInt32(row["Y"]) / jump;
                star.z = Convert.ToInt32(row["Z"]) / jump;
                star.xs = Convert.ToDouble(row["X"]);
                star.ys = Convert.ToDouble(row["Y"]);
                star.zs = Convert.ToDouble(row["Z"]);
                if(Convert.ToBoolean(row["Passed"]))
                {
                    star.passed = true;
                }
                star.point = Convert.ToInt32(row["Point"]);

                if (chRows.ContainsKey(star.z))
                {
                    chRows[star.z].Add(star);
                }
                else
                {
                    stars = new List<Star>();
                    stars.Add(star);
                    chRows.Add(star.z, stars);
                }

                if (maxz < star.z) maxz = star.z;
                if (minz > star.z) minz = star.z;
                if (maxx < star.x) maxx = star.x;
                if (minx > star.x) minx = star.x;
            }
            //количество рядов
            int chRowCount = maxz - minz;

            int indx;
            int keyz;

            chartRoute.Series.Clear();
            //Отметка -Z
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.MarkerStyle = MarkerStyle.Triangle;
            series.MarkerSize = 10;
            series.Color = Color.Black;
            series.Points.AddXY(0, 0);
            series.Points[0].Color = Color.Red;
            series.Points[0].Label = "-Z";
            series.Points[0].LabelForeColor = Color.White;

            chartRoute.Series.Add(series);
            //звезды
            for (int i = 0; i < chRowCount; i++)
            {
                series = new Series();
                series.ChartType = SeriesChartType.Point;
                series.MarkerStyle = MarkerStyle.Star6;
                series.MarkerSize = 10;
                series.Color = Color.Black;

                keyz = minz + i;
                if (chRows.ContainsKey(keyz))
                {
                    foreach (Star s in chRows[keyz])
                    {
                        indx = s.x - minx;
                        series.Points.AddXY(indx, s.y);
                        if (s.passed)
                        {
                            series.Points[series.Points.Count - 1].Color = Color.Green;
                        }
                        else
                        {
                            series.Points[series.Points.Count - 1].Color = Color.White;
                        }
                        series.Points[series.Points.Count - 1].Label = 
                            s.point.ToString() + " " + s.name;
                        series.Points[series.Points.Count - 1].LabelForeColor = Color.White;

                        text = s.name + "\n" +
                            "X: " + s.xs.ToString() + "\n" +
                            "Y: " + s.ys.ToString() + "\n" +
                            "Z: " + s.zs.ToString();
                        series.Points[series.Points.Count - 1].ToolTip = text;
                    }
                }
                else
                {
                    series.Points.AddXY(0, 0);
                }
                chartRoute.Series.Add(series);
            }
            //Отметка +Z
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.MarkerStyle = MarkerStyle.Triangle;
            series.MarkerSize = 10;
            series.Color = Color.Black;
            series.Points.AddXY(0, 0);
            series.Points[0].Color = Color.Green;
            series.Points[0].Label = "+Z";
            series.Points[0].LabelForeColor = Color.White;

            chartRoute.Series.Add(series);
        }

        private void nudChartRouteAngleX_ValueChanged(object sender, EventArgs e)
        {
            chartRoute.ChartAreas["RouteChartArea"].Area3DStyle.Inclination =
                (int)nudChartRouteAngleX.Value;
        }

        private void nudChartRouteAngleY_ValueChanged(object sender, EventArgs e)
        {
            chartRoute.ChartAreas["RouteChartArea"].Area3DStyle.Rotation =
                (int)nudChartRouteAngleY.Value;
        }

        private void chartRoute_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result;
            string name = "";
            if (e.Button == MouseButtons.Left)
            {
                result = chartRoute.HitTest(e.X, e.Y, ChartElementType.DataPoint);
                if (result.Object != null)
                    name = result.Series.Points[result.PointIndex].Label;
                tbxChartRouteSelected.Text = name;
            }
        }

        private void ChartSearch3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DXWindow search3D = new DXWindow("Search 3D");
            search3D.Run();
        }

        private void btnCoordsCalculate_Click(object sender, EventArgs e)
        {
            int point = 0;  //номер точки
            int angle1 = 0; //поворот вокруг y
            int angle2 = 0; //угол от плоскосит xz
            int step = (int)nudCoordsStep.Value;
            DataRow row;
            int cx = Convert.ToInt32(tbxCenterX.Text);
            int cy = Convert.ToInt32(tbxCenterY.Text);
            int cz = Convert.ToInt32(tbxCenterZ.Text);
            int r = Convert.ToInt32(tbxCenterRadius.Text);
            double rad = Math.PI / 180;
            Star star;
            double x;
            double y;
            double z;

            dtCoords.Clear();
            //нулевая точка сверху
            row = dtCoords.NewRow();
            row["ID"] = point;
            row["X"] = 0 + cx;
            row["Y"] = r + cy;
            row["Z"] = 0 + cz;

            lblCoordsStatus.Text = "Обрабатывается точка " + point.ToString();
            Application.DoEvents();

            star = GetNearestStar(0, r, 0);
            row["System"] = star.name;
            row["SX"] = star.xs;
            row["SY"] = star.ys;
            row["SZ"] = star.zs;

            dtCoords.Rows.Add(row);
            //остальные точки сферы
            for (angle2 = step; angle2< 180; angle2 += step)
            {
                for (angle1 = 0; angle1 < 360; angle1 += step)
                {
                    point++;
                    x = Math.Round(r * Math.Cos(angle1 * rad) *
                        Math.Sin(angle2 * rad) + cx, 2);
                    y = Math.Round(r * Math.Cos(angle2 * rad) + cz, 2);
                    z = Math.Round(r * Math.Sin(angle1 * rad) *
                        Math.Sin(angle2 * rad) + cy, 2);
                    row = dtCoords.NewRow();
                    row["ID"] = point;
                    row["X"] = x;
                    row["Y"] = y;
                    row["Z"] = z;

                    lblCoordsStatus.Text = "Обрабатывается точка " + point.ToString();
                    Application.DoEvents();

                    star = GetNearestStar(x, y, z);
                    row["System"] = star.name;
                    row["SX"] = star.xs;
                    row["SY"] = star.ys;
                    row["SZ"] = star.zs;

                    dtCoords.Rows.Add(row);
                }
            }
            //нулевая точка снизу
            point++;
            row = dtCoords.NewRow();
            row["ID"] = point;
            row["X"] = 0 + cx;
            row["Y"] = -r + cy;
            row["Z"] = 0 + cz;

            lblCoordsStatus.Text = "Обрабатывается точка " + point.ToString();
            Application.DoEvents();

            star = GetNearestStar(0, -r, 0);
            row["System"] = star.name;
            row["SX"] = star.xs;
            row["SY"] = star.ys;
            row["SZ"] = star.zs;

            dtCoords.Rows.Add(row);
            lblCoordsStatus.Text = "Готово";
        }

        private void CoordsCopyToSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCurrentSystem.Text = "";
            tbxCurrentX.Text = dgvCoords.CurrentRow.Cells["dgvcCooordsX"].Value.ToString();
            tbxCurrentY.Text = dgvCoords.CurrentRow.Cells["dgvcCooordsY"].Value.ToString();
            tbxCurrentZ.Text = dgvCoords.CurrentRow.Cells["dgvcCooordsZ"].Value.ToString();
            this.tabControl.SelectTab("tabPageSearch");
        }

        private void RouteDeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd.CommandText = @"DELETE FROM Route";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            dtRoute.Clear();
            dgvRoute.Update();
        }

        private void btnCoordsToRoute_Click(object sender, EventArgs e)
        {
            DataRow row;

            cmd.CommandText = @"DELETE FROM Route";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }

            dtRoute.Clear();
            foreach(DataRow r in dtCoords.Rows)
            {
                row = dtRoute.NewRow();
                row["ID"] = r["ID"];
                row["Point"] = r["ID"];
                row["System"] = r["System"];
                row["X"] = r["SX"];
                row["Y"] = r["SY"];
                row["Z"] = r["SZ"];
                row["Passed"] = 0;
                row["Comment"] = "";
                dtRoute.Rows.Add(row);

                //
                cmd.CommandText = @"INSERT INTO Route (ID, Point, System, X, Y, Z, Passed, Comment)
                                       VALUES (@ID, @Point, @System, @X, @Y, @Z, @Passed, @Comment)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ID", DbType.Int32).Value = row["ID"];
                cmd.Parameters.Add("@Point", DbType.Int32).Value = row["Point"];
                cmd.Parameters.Add("@System", DbType.String).Value = row["System"];
                cmd.Parameters.Add("@X", DbType.Double).Value = row["X"];
                cmd.Parameters.Add("@Y", DbType.Double).Value = row["Y"];
                cmd.Parameters.Add("@Z", DbType.Double).Value = row["Z"];
                cmd.Parameters.Add("@Passed", DbType.Int32).Value = row["Passed"];
                cmd.Parameters.Add("@Comment", DbType.String).Value = row["Comment"];

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    this.tbxResult.ForeColor = Color.Red;
                    this.tbxResult.Text = ex.Message;
                    return;
                }
            }
            this.tabControl.SelectTab("tabPageRoute");
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.lblFrom.Text = fbd.SelectedPath;
            }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.lblTo.Text = fbd.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbxLog.Text = "";
            if (lblFrom.Text == "" || lblTo.Text == "")
            {
                tbxLog.Text = "Не выбраны каталоги" + Environment.NewLine;
                return;
            }
            DirCopy(lblFrom.Text, lblTo.Text, DateTime.Now);
        }
        private void DirCopy(string from, string to, DateTime dt)
        {
            FileInfo[] files = null;
            DirectoryInfo infoFrom;
            DirectoryInfo[] subDir = null;
            int ind;
            string dir;
            string sub;

            infoFrom = new DirectoryInfo(from);
            subDir = infoFrom.GetDirectories();
            for (int i = 0; i < subDir.Length; i++)
            {
                sub = subDir[i].FullName;
                ind = sub.LastIndexOf(@"\");
                dir = to + "\\" + sub.Substring(ind + 1);
                if (!Directory.Exists(dir))
                {
                    try
                    {
                        Directory.CreateDirectory(dir);
                        this.tbxLog.Text = "Создан каталог " + dir + Environment.NewLine + this.tbxLog.Text;
                    }
                    catch (Exception ex)
                    {
                        this.tbxLog.Text = "Ошибка: "+ ex.Message + this.tbxLog.Text;
                    }
                }
                Application.DoEvents();
                this.DirCopy(sub, dir, dt);
            }
            files = infoFrom.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                this.FileCopy(files[i].FullName, to, dt);
                Application.DoEvents();
            }
        }
        private void FileCopy(string from, string to, DateTime dt)
        {
            long sizeFrom;
            long sizeTo;
            FileInfo infoFrom;
            FileInfo infoTo;
            int ind;
            string fileName;

            ind = from.LastIndexOf(@"\");
            fileName = from.Substring(ind + 1);
            to += "\\" + fileName;
            if (File.Exists(to))
            {
                infoFrom = new FileInfo(from);
                infoTo = new FileInfo(to);
                sizeFrom = infoFrom.Length;
                sizeTo = infoTo.Length;
                if (sizeFrom != sizeTo)
                {
                    try
                    {
                        File.Copy(from, to, true);
                        this.tbxLog.Text = "Обновлен файл " + fileName + Environment.NewLine + this.tbxLog.Text;
                    }
                    catch (Exception ex)
                    {
                        this.tbxLog.Text = "Ошибка: " + ex.Message + this.tbxLog.Text;
                    }
                }
            }
            else
            {
                try
                {
                    File.Copy(from, to, true);
                    this.tbxLog.Text = "Создан файл " + fileName + Environment.NewLine + this.tbxLog.Text;
                }
                catch (Exception ex)
                {
                    this.tbxLog.Text = "Ошибка: " + ex.Message + this.tbxLog.Text;
                }
            }
        }

        private void dgvRoute_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (load) return;
            cmd.CommandText = @"UPDATE Route
                                SET Point = @Point,
                                    Passed = @Passed,
                                    Comment = @Comment
                                WHERE ID = @ID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", DbType.Int32).Value =
                Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRouteID"].Value);
            cmd.Parameters.Add("@Point", DbType.Int32).Value =
                Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRoutePoint"].Value);
            cmd.Parameters.Add("@Passed", DbType.Int32).Value =
                Convert.ToInt32(dgvRoute.CurrentRow.Cells["dgvRoutePassed"].Value);
            cmd.Parameters.Add("@Comment", DbType.String).Value =
                Convert.ToString(dgvRoute.CurrentRow.Cells["dgvRouteComment"].Value);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                this.tbxResult.ForeColor = Color.Red;
                this.tbxResult.Text = ex.Message;
                return;
            }
        }
    }
}
