﻿namespace StockPortfolioTracker.Common;

public class EntityUserRoles
{
    #region Constants
    public const int SUPERUSERID = 1;
    public const int USERID = 2;

    public const string SUPERUSER = "Super User";
    public const string USER = "User";

    // Combination - For Authorization
    public const string SUPERUSER_WITH_USER = $"{SUPERUSER},{USER}";
    #endregion
}