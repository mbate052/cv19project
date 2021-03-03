using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using cv19project.Model;
using cv19project.services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cv19project.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]

    public class ErrorModel : PageModel
    {
        private readonly ILogger<ErrorModel> _logger;
        private ProvincesService myProvincesService;

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public ProvincesService MyProvincesService { get => myProvincesService; set => myProvincesService = value; }

        public ErrorModel(ILogger<ErrorModel> logger) => _logger = logger;

        public void OnGet()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override BadRequestResult BadRequest()
        {
            return base.BadRequest();
        }

        public override BadRequestObjectResult BadRequest(object error)
        {
            return base.BadRequest(error);
        }

        public override BadRequestObjectResult BadRequest(ModelStateDictionary modelState)
        {
            return base.BadRequest(modelState);
        }

        public override ChallengeResult Challenge()
        {
            return base.Challenge();
        }

        public override ChallengeResult Challenge(params string[] authenticationSchemes)
        {
            return base.Challenge(authenticationSchemes);
        }

        public override ChallengeResult Challenge(AuthenticationProperties properties)
        {
            return base.Challenge(properties);
        }

        public override ChallengeResult Challenge(AuthenticationProperties properties, params string[] authenticationSchemes)
        {
            return base.Challenge(properties, authenticationSchemes);
        }

        public override ContentResult Content(string content)
        {
            return base.Content(content);
        }

        public override ContentResult Content(string content, string contentType)
        {
            return base.Content(content, contentType);
        }

        public override ContentResult Content(string content, string contentType, Encoding contentEncoding)
        {
            return base.Content(content, contentType, contentEncoding);
        }

        public override ContentResult Content(string content, MediaTypeHeaderValue contentType)
        {
            return base.Content(content, contentType);
        }

        public override ForbidResult Forbid()
        {
            return base.Forbid();
        }

        public override ForbidResult Forbid(params string[] authenticationSchemes)
        {
            return base.Forbid(authenticationSchemes);
        }

        public override ForbidResult Forbid(AuthenticationProperties properties)
        {
            return base.Forbid(properties);
        }

        public override ForbidResult Forbid(AuthenticationProperties properties, params string[] authenticationSchemes)
        {
            return base.Forbid(properties, authenticationSchemes);
        }

        public override FileContentResult File(byte[] fileContents, string contentType)
        {
            return base.File(fileContents, contentType);
        }

        public override FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName)
        {
            return base.File(fileContents, contentType, fileDownloadName);
        }

        public override FileStreamResult File(Stream fileStream, string contentType)
        {
            return base.File(fileStream, contentType);
        }

        public override FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName)
        {
            return base.File(fileStream, contentType, fileDownloadName);
        }

        public override VirtualFileResult File(string virtualPath, string contentType)
        {
            return base.File(virtualPath, contentType);
        }

        public override VirtualFileResult File(string virtualPath, string contentType, string fileDownloadName)
        {
            return base.File(virtualPath, contentType, fileDownloadName);
        }

        public override LocalRedirectResult LocalRedirect(string localUrl)
        {
            return base.LocalRedirect(localUrl);
        }

        public override LocalRedirectResult LocalRedirectPermanent(string localUrl)
        {
            return base.LocalRedirectPermanent(localUrl);
        }

        public override LocalRedirectResult LocalRedirectPreserveMethod(string localUrl)
        {
            return base.LocalRedirectPreserveMethod(localUrl);
        }

        public override LocalRedirectResult LocalRedirectPermanentPreserveMethod(string localUrl)
        {
            return base.LocalRedirectPermanentPreserveMethod(localUrl);
        }

        public override NotFoundResult NotFound()
        {
            return base.NotFound();
        }

        public override NotFoundObjectResult NotFound(object value)
        {
            return base.NotFound(value);
        }

        public override PageResult Page()
        {
            return base.Page();
        }

        public override PhysicalFileResult PhysicalFile(string physicalPath, string contentType)
        {
            return base.PhysicalFile(physicalPath, contentType);
        }

        public override PhysicalFileResult PhysicalFile(string physicalPath, string contentType, string fileDownloadName)
        {
            return base.PhysicalFile(physicalPath, contentType, fileDownloadName);
        }

        public override RedirectResult RedirectPermanent(string url)
        {
            return base.RedirectPermanent(url);
        }

        public override RedirectResult RedirectPreserveMethod(string url)
        {
            return base.RedirectPreserveMethod(url);
        }

        public override RedirectResult RedirectPermanentPreserveMethod(string url)
        {
            return base.RedirectPermanentPreserveMethod(url);
        }

        public override RedirectToActionResult RedirectToAction(string actionName)
        {
            return base.RedirectToAction(actionName);
        }

        public override RedirectToActionResult RedirectToAction(string actionName, object routeValues)
        {
            return base.RedirectToAction(actionName, routeValues);
        }

        public override RedirectToActionResult RedirectToAction(string actionName, string controllerName)
        {
            return base.RedirectToAction(actionName, controllerName);
        }

        public override RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues)
        {
            return base.RedirectToAction(actionName, controllerName, routeValues);
        }

        public override RedirectToActionResult RedirectToAction(string actionName, string controllerName, string fragment)
        {
            return base.RedirectToAction(actionName, controllerName, fragment);
        }

        public override RedirectToActionResult RedirectToAction(string actionName, string controllerName, object routeValues, string fragment)
        {
            return base.RedirectToAction(actionName, controllerName, routeValues, fragment);
        }

        public override RedirectToActionResult RedirectToActionPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToActionPreserveMethod(actionName, controllerName, routeValues, fragment);
        }

        public override RedirectToActionResult RedirectToActionPermanent(string actionName)
        {
            return base.RedirectToActionPermanent(actionName);
        }

        public override RedirectToActionResult RedirectToActionPermanent(string actionName, object routeValues)
        {
            return base.RedirectToActionPermanent(actionName, routeValues);
        }

        public override RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName)
        {
            return base.RedirectToActionPermanent(actionName, controllerName);
        }

        public override RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, string fragment)
        {
            return base.RedirectToActionPermanent(actionName, controllerName, fragment);
        }

        public override RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues)
        {
            return base.RedirectToActionPermanent(actionName, controllerName, routeValues);
        }

        public override RedirectToActionResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues, string fragment)
        {
            return base.RedirectToActionPermanent(actionName, controllerName, routeValues, fragment);
        }

        public override RedirectToActionResult RedirectToActionPermanentPreserveMethod(string actionName = null, string controllerName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToActionPermanentPreserveMethod(actionName, controllerName, routeValues, fragment);
        }

        public override RedirectToRouteResult RedirectToRoute(string routeName)
        {
            return base.RedirectToRoute(routeName);
        }

        public override RedirectToRouteResult RedirectToRoute(object routeValues)
        {
            return base.RedirectToRoute(routeValues);
        }

        public override RedirectToRouteResult RedirectToRoute(string routeName, object routeValues)
        {
            return base.RedirectToRoute(routeName, routeValues);
        }

        public override RedirectToRouteResult RedirectToRoute(string routeName, string fragment)
        {
            return base.RedirectToRoute(routeName, fragment);
        }

        public override RedirectToRouteResult RedirectToRoute(string routeName, object routeValues, string fragment)
        {
            return base.RedirectToRoute(routeName, routeValues, fragment);
        }

        public override RedirectToRouteResult RedirectToRoutePreserveMethod(string routeName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToRoutePreserveMethod(routeName, routeValues, fragment);
        }

        public override RedirectToRouteResult RedirectToRoutePermanent(string routeName)
        {
            return base.RedirectToRoutePermanent(routeName);
        }

        public override RedirectToRouteResult RedirectToRoutePermanent(object routeValues)
        {
            return base.RedirectToRoutePermanent(routeValues);
        }

        public override RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues)
        {
            return base.RedirectToRoutePermanent(routeName, routeValues);
        }

        public override RedirectToRouteResult RedirectToRoutePermanent(string routeName, string fragment)
        {
            return base.RedirectToRoutePermanent(routeName, fragment);
        }

        public override RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues, string fragment)
        {
            return base.RedirectToRoutePermanent(routeName, routeValues, fragment);
        }

        public override RedirectToRouteResult RedirectToRoutePermanentPreserveMethod(string routeName = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToRoutePermanentPreserveMethod(routeName, routeValues, fragment);
        }

        public override RedirectToPageResult RedirectToPage()
        {
            return base.RedirectToPage();
        }

        public override RedirectToPageResult RedirectToPage(object routeValues)
        {
            return base.RedirectToPage(routeValues);
        }

        public override RedirectToPageResult RedirectToPage(string pageName)
        {
            return base.RedirectToPage(pageName);
        }

        public override RedirectToPageResult RedirectToPage(string pageName, string pageHandler)
        {
            return base.RedirectToPage(pageName, pageHandler);
        }

        public override RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues)
        {
            return base.RedirectToPage(pageName, pageHandler, routeValues);
        }

        public override RedirectToPageResult RedirectToPage(string pageName, object routeValues)
        {
            return base.RedirectToPage(pageName, routeValues);
        }

        public override RedirectToPageResult RedirectToPage(string pageName, string pageHandler, string fragment)
        {
            return base.RedirectToPage(pageName, pageHandler, fragment);
        }

        public override RedirectToPageResult RedirectToPage(string pageName, string pageHandler, object routeValues, string fragment)
        {
            return base.RedirectToPage(pageName, pageHandler, routeValues, fragment);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName)
        {
            return base.RedirectToPagePermanent(pageName);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues)
        {
            return base.RedirectToPagePermanent(pageName, routeValues);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler, routeValues);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, string fragment)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler, fragment);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName, object routeValues, string fragment)
        {
            return base.RedirectToPagePermanent(pageName, routeValues, fragment);
        }

        public override RedirectToPageResult RedirectToPagePermanent(string pageName, string pageHandler, object routeValues, string fragment)
        {
            return base.RedirectToPagePermanent(pageName, pageHandler, routeValues, fragment);
        }

        public override RedirectToPageResult RedirectToPagePreserveMethod(string pageName = null, string pageHandler = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToPagePreserveMethod(pageName, pageHandler, routeValues, fragment);
        }

        public override RedirectToPageResult RedirectToPagePermanentPreserveMethod(string pageName = null, string pageHandler = null, object routeValues = null, string fragment = null)
        {
            return base.RedirectToPagePermanentPreserveMethod(pageName, pageHandler, routeValues, fragment);
        }

        public override SignInResult SignIn(ClaimsPrincipal principal, string authenticationScheme)
        {
            return base.SignIn(principal, authenticationScheme);
        }

        public override SignInResult SignIn(ClaimsPrincipal principal, AuthenticationProperties properties, string authenticationScheme)
        {
            return base.SignIn(principal, properties, authenticationScheme);
        }

        public override SignOutResult SignOut(params string[] authenticationSchemes)
        {
            return base.SignOut(authenticationSchemes);
        }

        public override SignOutResult SignOut(AuthenticationProperties properties, params string[] authenticationSchemes)
        {
            return base.SignOut(properties, authenticationSchemes);
        }

        public override StatusCodeResult StatusCode(int statusCode)
        {
            return base.StatusCode(statusCode);
        }

        public override ObjectResult StatusCode(int statusCode, object value)
        {
            return base.StatusCode(statusCode, value);
        }

        public override UnauthorizedResult Unauthorized()
        {
            return base.Unauthorized();
        }

        public override PartialViewResult Partial(string viewName)
        {
            return base.Partial(viewName);
        }

        public override PartialViewResult Partial(string viewName, object model)
        {
            return base.Partial(viewName, model);
        }

        public override ViewComponentResult ViewComponent(string componentName)
        {
            return base.ViewComponent(componentName);
        }

        public override ViewComponentResult ViewComponent(Type componentType)
        {
            return base.ViewComponent(componentType);
        }

        public override ViewComponentResult ViewComponent(string componentName, object arguments)
        {
            return base.ViewComponent(componentName, arguments);
        }

        public override ViewComponentResult ViewComponent(Type componentType, object arguments)
        {
            return base.ViewComponent(componentType, arguments);
        }

        public override bool TryValidateModel(object model)
        {
            return base.TryValidateModel(model);
        }

        public override bool TryValidateModel(object model, string name)
        {
            return base.TryValidateModel(model, name);
        }

        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            base.OnPageHandlerSelected(context);
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            base.OnPageHandlerExecuting(context);
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            base.OnPageHandlerExecuted(context);
        }

        public override Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return base.OnPageHandlerSelectionAsync(context);
        }

        public override Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            return base.OnPageHandlerExecutionAsync(context, next);
        }
    }
}
