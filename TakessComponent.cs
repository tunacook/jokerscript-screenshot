using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Novel
{
    public class TakessComponent : AbstractComponent
    {
        public TakessComponent()
        {
            // パラメータの定義
            this.arrayVitalParam = new List<string>
            {
                "filename", "resolution"
            };

            // パラメータの初期値
            this.originalParam = new Dictionary<string, string>()
            {
                // 初期値は空文字
                {"filename", ""},
                {"resolution", "1"},
            };
        }

        // startメソッドをオーバーライドしたもの
        public override void start()
        {
            string filename = this.param["filename"];
            int resolution = int.Parse(this.param["resolution"]);

            var storagepath = Application.persistentDataPath + "/screenshots/";

            //ディレクトリがなければ作成
            if (!Directory.Exists(storagepath))
            {
                Directory.CreateDirectory(storagepath);
            }

            var filepath = storagepath + filename + ".png";
            Application.CaptureScreenshot(filepath, resolution);
        }
    }
}
