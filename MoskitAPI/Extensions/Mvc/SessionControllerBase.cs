﻿using Microsoft.AspNetCore.Mvc;

using Moskit.Extensions.Identity;

namespace Moskit.Extensions.Mvc
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class SessionControllerBase
        : ControllerBase
    {
        protected readonly UserManagerExt? userManager;
        protected readonly SignInManagerExt? signInManager;
        protected readonly ILogger<SessionControllerBase>? logger;

        public SessionControllerBase (
            UserManagerExt? userManager = null,
            SignInManagerExt? signInManager = null,
            ILogger<SessionControllerBase>? logger = null)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
        }
    }
}
