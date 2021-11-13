﻿using MudBlazor;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.Theme
{
    public class DarkTheme : MudTheme
    {
        public DarkTheme()
        {
            Palette = new Palette()
            {
                Primary = CustomColors.Dark.Primary,
                Secondary = CustomColors.Dark.Secondary,
                Success = "#007E33",
                Black = "#27272f",
                Background = CustomColors.Dark.Background,
                BackgroundGrey = "#27272f",
                Surface = CustomColors.Dark.Surface,
                DrawerBackground = CustomColors.Dark.DrawerBackground,
                DrawerText = "rgba(255,255,255, 0.50)",
                AppbarBackground = CustomColors.Dark.AppbarBackground,
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                TableLines = "#e0e0e029",
                Dark = CustomColors.Dark.DrawerBackground
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "5px",
            };

            Typography = CustomTypography.FSHTypography;
            Shadows = new Shadow();
            ZIndex = new ZIndex();
        }
    }
}