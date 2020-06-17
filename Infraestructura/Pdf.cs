using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;
using System.IO;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(List<Empleado> empleado, string path)
        {

            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion Pulsacion");
            document.Open();
            document.Add(new Paragraph("INFORME DE PERSONAS REGISTRADAS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(empleado));

            document.Close();

        }

        private PdfPTable LlenarTabla(List<Empleado> empleado)
        {
            PdfPTable tabla = new PdfPTable(6);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Primer Nombre"));
            tabla.AddCell(new Paragraph("Segundo Nombre"));
            tabla.AddCell(new Paragraph("Primer Apellido"));
            tabla.AddCell(new Paragraph("Segundo Apellido"));
            tabla.AddCell(new Paragraph("Codigo de puesto"));

            foreach (var item in empleado)
            {
                tabla.AddCell(new Paragraph(item.Cedula));
                tabla.AddCell(new Paragraph(item.PrimerNombre));
                tabla.AddCell(new Paragraph(item.SegundoNombre));
                tabla.AddCell(new Paragraph(item.PrimerApellido));
                tabla.AddCell(new Paragraph(item.SegundoApellido));
                tabla.AddCell(new Paragraph(item.IdPuesto));
            }
            return tabla;
        }

    }

}