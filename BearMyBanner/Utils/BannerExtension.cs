using BearMyBanner.Wrapper;
using TaleWorlds.Core;

namespace BearMyBanner
{
    public static class BannerExtension
    {
        public const int mainColorPlaceholderId = 40;
        public const int iconColorPlaceholderId = 116;
        
        public static void ChangeBanner(this Banner banner, IBMBBanner newBanner)
        {
            banner.Deserialize(newBanner.Key);
        }

        public static void ChangeBaseColors(this Banner banner, int colorId, int colorId2)
        {
            banner.BannerDataList[0].ColorId = colorId;
            banner.BannerDataList[0].ColorId2 = colorId2;
        }

        public static void ChangeIconColor(this Banner banner, int colorId)
        {
            for (int i = 1; i < banner.BannerDataList.Count; i++)
            {
                banner.BannerDataList[i].ColorId = colorId;
            }
        }

        public static void ChangeIconMesh(this Banner banner, int meshId)
        {
            for (int i = 1; i < banner.BannerDataList.Count; i++)
            {
                banner.BannerDataList[i].MeshId = meshId;
            }
        }
        
        public static Banner ReplacePlaceholderBannerColors(this Banner banner, uint mainColor, uint iconColor)
        {
            int mainColorId = BannerManager.GetColorId(mainColor);
            int iconColorId = BannerManager.GetColorId(iconColor);
            
            if (mainColorId < 0 || iconColorId < 0)
            {
                return banner;
            }
            
            for (int index = 0; index < banner.BannerDataList.Count; ++index)
            {
                banner.BannerDataList[index].ColorId = 
                    EvaluatePlaceholderReplacementColor(banner.BannerDataList[index].ColorId, mainColorId, iconColorId);
                banner.BannerDataList[index].ColorId2 = 
                    EvaluatePlaceholderReplacementColor(banner.BannerDataList[index].ColorId2, mainColorId, iconColorId);;
            }

            return banner;
        }

        private static int EvaluatePlaceholderReplacementColor(int inputColor, int mainColorId, int iconColorId)
        {
            switch (inputColor)
            {
                case mainColorPlaceholderId:
                    return mainColorId;
                case iconColorPlaceholderId:
                    return iconColorId;
                default:
                    return inputColor;
            }
        }
    }
}
