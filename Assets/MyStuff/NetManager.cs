using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using Enjin.SDK.GraphQL;
using Enjin.SDK.Core;

public class NetManager : MonoBehaviour
{

     void Start()
     {

        string api = "https://kovan.cloud.enjin.io/graphql";

        Enjin.SDK.Core.Enjin.StartPlatform(api, 2671, "KqcX8nFfLSzxHQK9uc0nGvtuF51CqcnDSdSNSLJZ");
        //print(enjinUsers);

        //print("CURRENT USER" + enjinUsers.GetCurrentUser());

     }

    

    public void ClickBtn()
    {
        StartCoroutine(POST_CALL());
        print("CLICK POST");
    }

    private IEnumerator POST_CALL()
    {
        yield return new WaitForSeconds(0.0f);


        //var jsonBinary = System.Text.Encoding.UTF8.GetBytes(json);

        //DownloadHandlerBuffer downloadHandlerBuffer = new DownloadHandlerBuffer();

        //UploadHandlerRaw uploadHandlerRaw = new UploadHandlerRaw(jsonBinary);
        //uploadHandlerRaw.contentType = "application/json";

        //UnityWebRequest www =
        //    new UnityWebRequest(url, "POST", downloadHandlerBuffer, uploadHandlerRaw);

        //yield return www.SendWebRequest();

        //print("POST___CALL___");

        //if (www.isNetworkError)
        //{
        //    Debug.LogError(string.Format("{0}: {1}", www.url, www.error));
        //}
        //else
        //{
        //    string myTest = "" + www.downloadHandler.text;
        //    string someText = myTest.ToLower();

        //    print(someText);


        //        if (someText.Contains("does not exist".ToLower()))
        //        {   //// WRONG USER DATA
        //            print("Error msg");
        //        }
        //        else if (someText.Contains("wallet_id".ToLower()))
        //        {


        //        }

        //        //**********************************************************************************************
        //        //**********************************************************************************************

        //    }


        //}
        print("MAKE A CALL");
    }
    




}
