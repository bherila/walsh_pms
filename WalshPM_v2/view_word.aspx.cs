using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace WalshPM_v2 {
    public partial class view_word : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string filename = Cache[Request["id"]].ToString();
            string ftol = filename.ToLower();
            string html = string.Empty;

            if (ftol.EndsWith("docx") || ftol.EndsWith("doc") || ftol.EndsWith("mht") || ftol.EndsWith("odf") || ftol.EndsWith("rtf")) {
                Aspose.Words.Document d = new Aspose.Words.Document(filename);
                d.SaveOptions.HtmlExportImagesFolderAlias = "/tmp";
                d.SaveOptions.ExportImagesFolder = Server.MapPath("/tmp");
                d.SaveOptions.HtmlExportEncoding = Encoding.UTF8;
                using (MemoryStream ms = new MemoryStream()) {
                    string vf = "/tmp/" + Guid.NewGuid().ToString("N") + ".png";
                    Aspose.Words.Rendering.ImageOptions io = new Aspose.Words.Rendering.ImageOptions();
                    io.JpegQuality = 90;
                    io.PaperColor = System.Drawing.Color.White;
                    io.Resolution = 90;
                    d.SaveToImage(0, 1, Server.MapPath(vf), io);

                    html = "<img src='" + vf + "' />";
                    //d.Save(ms, Aspose.Words.SaveFormat.Html);
                    //html = Encoding.UTF8.GetString(ms.ToArray());
                    ms.Close();
                }
            }
            else if (ftol.EndsWith("xls") || ftol.EndsWith("xlsx")) {
                Aspose.Cells.Workbook d = new Aspose.Cells.Workbook();
                d.Open(filename);
                using (MemoryStream ms = new MemoryStream()) {
                    d.Save(ms, Aspose.Cells.FileFormatType.Html);
                    html = Encoding.UTF8.GetString(ms.ToArray());
                    ms.Close();
                }
            }
            //else if (ftol.EndsWith("pdf")) {
            //    Aspose.Recognition.PdfRecognizer r = new Aspose.Recognition.PdfRecognizer();
            //    r.Open(filename);
            //    using (MemoryStream ms = new MemoryStream()) {
            //        r.Save(ms, Aspose.Recognition.SaveFormat.Html);
            //        html = Encoding.UTF8.GetString(ms.ToArray());
            //        ms.Close();
            //    }
            //}
            else if (ftol.EndsWith("jpg")) {
                Response.Clear();
                Response.ContentType = "image/jpeg"; 
                Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(filename));
                Response.WriteFile(filename);
                Response.End();
            }
            else if (ftol.EndsWith("gif")) {
                Response.Clear();
                Response.ContentType = "image/gif";
                Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(filename));
                Response.WriteFile(filename);
                Response.End();
            }
            else if (ftol.EndsWith("png")) {
                Response.Clear();
                Response.ContentType = "image/png";
                Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(filename));
                Response.WriteFile(filename);
                Response.End();
            }
            else if (ftol.EndsWith("pdf")) {
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(filename));
                Response.WriteFile(filename);
                Response.End();
            }
            else if (ftol.EndsWith("bmp")) {
                Response.Clear();
                Response.ContentType = "image/bmp";
                Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(filename));
                Response.WriteFile(filename);
                Response.End();
            }

            html = Regex.Replace(html, "aspose[A-Z.]+", "PM_Preview", RegexOptions.IgnoreCase);
            //html = Regex.Match(html, "<body.*?>(.+)</body>", RegexOptions.IgnoreCase | RegexOptions.Multiline).Groups[1].Value;
            litHtml.Text = html;
        }
    }
}
