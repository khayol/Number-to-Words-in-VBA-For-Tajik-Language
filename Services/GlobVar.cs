using System;
using System.Linq;
using Woorj.Data;
using Woorj.Services;

namespace Woorj.Services
{  
    public class GlobVar
    {

        //==========================================================
        // Password settings  
        public bool requireDigit { get; set; } = true;
        public int requiredLength { get; set; } = 8;
        public bool requireNonAlphanumeric { get; set; } = false;
        public bool requireUppercase { get; set; } = true;
        public bool requireLowercase { get; set; } = false;
        public int requiredUniqueChars { get; set; } = 6;

        // Lockout settings  
        public int defaultLockoutTimeSpan { get; set; } = 180; //2; 180
        public int maxFailedAccessAttempts { get; set; } = 3; //10;
        public bool allowedForNewUsers { get; set; } = true;

        // User settings  
        public bool requireUniqueEmail { get; set; } = true;

        // Cookie settings  
        public bool httpOnly { get; set; } = true;
        public int expireTimeSpan { get; set; } = 180; //2; 180
        public string loginPath { get; set; } = "/Identity/Account/Login";
        public string logoutPath { get; set; } = "/Identity/Account/Logout";
        public string accessDeniedPath { get; set; } = "/Identity/Account/AccessDenied";
        public bool slidingExpiration { get; set; } = true;
        //==========================================================
    } 


}