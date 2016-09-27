namespace LetsEncrypt.Umbraco
{
    using global::Umbraco.Web;

    using Microsoft.Owin;
    using Microsoft.Owin.FileSystems;

    using Owin;

    public class LetsEncryptStartup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            app.Map("/.well-known", letsEncrypt =>
            {
                letsEncrypt.Use((context, next) =>
                {
                    IFileInfo file;

                    var fileSystem = new PhysicalFileSystem(@".\.well-known");

                    return !fileSystem.TryGetFileInfo(context.Request.Path.Value, out file) ? next() : context.Response.SendFileAsync(file.PhysicalPath);
                });
            });

            base.Configuration(app);
        }
    }
}