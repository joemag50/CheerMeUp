using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        showBannerAd();
    }

    private void showBannerAd()
    {
        //***For Production When Submit App***
        string adID = "ca-app-pub-9534556889768666/7521056124";
        AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
        bannerAd.LoadAd(request);
    }

    // Update is called once per frame
    void Update()
    {

    }
}