Overrides Umbraco.Web.UmbracoDefaultOwinStartup to allow static files serving from .well-know directory in webroot.
Based on solution, proposed by James Diggle in https://www.jdibble.co.uk/blog/using-letsencrypt-with-umbraco and StackOverflow post http://stackoverflow.com/questions/38855040/azure-letsencrypt-extension-cannot-access-well-known-acme-challenge-in-umbraco

Also, this package will add example rewrite rule to ensure that requests for URLs, containing `well-known/acme-challenge/` will be passed as is. 