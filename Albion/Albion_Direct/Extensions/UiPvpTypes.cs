﻿namespace Albion_Direct
{
    public enum UiPvpTypes
    {
        Safe = 0,
        Limited = 1,
        Full = 2,
        Black = 3
    }

    public static class UiPvpTypesExtensions
    {
        public static ka.UiPvpTypes ToInternal(this UiPvpTypes instance)
        {
            return (ka.UiPvpTypes)instance;
        }

        public static UiPvpTypes ToWrapped(this ka.UiPvpTypes instance)
        {
            return (UiPvpTypes)instance;
        }
    }
}