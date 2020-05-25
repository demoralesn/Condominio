using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.DAL;
using System.Data;

namespace CondominioWeb.Controllers
{
    public class ExportarController : Controller
    {
        // GET: Exportar
        public FileResult Index(int id)
        {
            var GridHtml = CargarDcto(id);

            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Estado_Cuenta.pdf");
            }
        }
        private String CargarDcto(int tipo)
        {
            var FormatoDcto = BaseDatos.ExecuteScalar("select format from document_format where document_format_id=" + tipo + "");

            return FormatoDcto.ToString();
        }
    }
}