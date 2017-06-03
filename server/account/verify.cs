using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using db;
using MySql.Data.MySqlClient;

namespace server.account
{
    internal class verify : IRequestHandler
    {
        public void HandleRequest(HttpListenerContext context)
        {
            NameValueCollection query;
            using (var rdr = new StreamReader(context.Request.InputStream))
                query = HttpUtility.ParseQueryString(rdr.ReadToEnd());

            using (var db = new Database())
            {
                Account acc = db.Verify(query["guid"], query["password"]);
                if (acc == null)
                {
                    byte[] status = Encoding.UTF8.GetBytes("<Error>Hey dude! You put incorrect password or username.</Error>");
                    context.Response.OutputStream.Write(status, 0, status.Length);
                    db.Dispose();
                }
                else
                {
                    var serializer = new XmlSerializer(acc.GetType(),
                        new XmlRootAttribute(acc.GetType().Name) {Namespace = ""});

                    var xws = new XmlWriterSettings();
                    xws.OmitXmlDeclaration = true;
                    xws.Encoding = Encoding.UTF8;
                    XmlWriter xtw = XmlWriter.Create(context.Response.OutputStream, xws);
                    serializer.Serialize(xtw, acc, acc.Namespaces);
                    db.Dispose();
                }
            }
        }
    }
}