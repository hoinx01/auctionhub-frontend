﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Web.Middlewares
{
    public class SampleAsyncPageFilter : IAsyncPageFilter
    {

        public SampleAsyncPageFilter()
        {

        }

        public async Task OnPageHandlerSelectionAsync(
                                            PageHandlerSelectedContext context)
        {
            
            await Task.CompletedTask;
        }

        public async Task OnPageHandlerExecutionAsync(
                                            PageHandlerExecutingContext context,
                                            PageHandlerExecutionDelegate next)
        {

            await next.Invoke();
        }
    }
}
