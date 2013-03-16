using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class saveImage : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		int seq = new Random().Next(0, 9999999);
		System.Drawing.Image img = System.Drawing.Image.FromStream(Request.InputStream);
		img.Save(Server.MapPath("./") + "/" + seq + ".jpg");
		string fileName = Request.Headers["fileName"];
		fileName = Server.UrlDecode(fileName);

		Response.Write("./"+seq+".jpg");
	}
}
