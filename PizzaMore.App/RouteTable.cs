﻿namespace PizzaMore.App
{
    using System.Collections.Generic;
    using PizzaMore.App.Helpers;
    using SimpleHttpServer.Enums;
    using SimpleHttpServer.Models;
    using SimpleMVC.Routers;

    public static class RouteTable
    {
        public static IEnumerable<Route> Routes
        {
            get
            {
                return new Route[]
                {
                    new Route()
                    {
                        Name = "Bootstrap CSS",
                        Method = RequestMethod.GET,
                        UrlRegex = "/bootstrap/css/bootstrap.min.css$",
                        Callable = (request) =>
                        {
                            var response = new HttpResponse()
                            {
                                StatusCode = ResponseStatusCode.Ok,
                                ContentAsUTF8 = PathReader.Read("../../content/bootstrap/css/bootstrap.min.css")
                            };
                            response.Header.ContentType = "text/css";
                            return response;
                        }
                    },
                    new Route()
                    {
                        Name = "Main CSS",
                        Method = RequestMethod.GET,
                        UrlRegex = "/css/main.css$",
                        Callable = (request) =>
                        {
                            var response = new HttpResponse()
                            {
                                StatusCode = ResponseStatusCode.Ok,
                                ContentAsUTF8 = PathReader.Read("../../content/css/main.css")
                            };
                            response.Header.ContentType = "text/css";
                            return response;
                        }
                    },
                    new Route()
                    {
                      Name = "Bootstrap Map",
                        Method = RequestMethod.GET,
                        UrlRegex = "/bootstrap/css/bootstrap.min.css.map$",
                        Callable = (request) =>
                        {
                            var response = new HttpResponse()
                            {
                                StatusCode = ResponseStatusCode.Ok,
                                ContentAsUTF8 =PathReader.Read("../../content/bootstrap/css/bootstrap.min.css.map")
                            };
                            response.Header.ContentType = "application/json";
                            return response;
                        }
                    },
                    new Route()
                    {
                        Name = "Jquery js",
                        Method = RequestMethod.GET,
                        UrlRegex = "/jquery/jquery-3.1.1.js$",
                        Callable = (request) =>
                        {
                            var response = new HttpResponse()
                            {
                                StatusCode = ResponseStatusCode.Ok,
                                ContentAsUTF8 = PathReader.Read("../../content/jquery/jquery-3.1.1.js")
                            };
                            response.Header.ContentType = "application/x-javascript";
                            return response;
                        }
                    },
                     new Route()
                    {
                        Name = "Bootstrap JS",
                        Method = RequestMethod.GET,
                        UrlRegex = "/bootstrap/js/bootstrap.min.js$",
                        Callable = (request) =>
                        {
                            var response = new HttpResponse()
                            {
                                StatusCode = ResponseStatusCode.Ok,
                                ContentAsUTF8 = PathReader.Read("../../content/bootstrap/js/bootstrap.min.js")
                            };
                            response.Header.ContentType = "application/x-javascript";
                            return response;
                        }
                    },
                    


                    new Route()
                    {
                        Name = "Controller/Action/GET",
                        Method = RequestMethod.GET,
                        UrlRegex = @"^/(.+)/(.+)$",
                        Callable = new ControllerRouter().Handle
                    },
                    new Route()
                    {
                        Name = "Controller/Action/POST",
                        Method = RequestMethod.POST,
                        UrlRegex = @"^/(.+)/(.+)$",
                        Callable = new ControllerRouter().Handle
                    }
                };
            }
        }
    }
}