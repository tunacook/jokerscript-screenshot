using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace Novel
{
    public class TakescreenshotComponent : AbstractComponent
    {
        public TakescreenshotComponent()
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
            execute();
        }

        private void execute()
        {
            string filename = this.param["filename"];
            int resolution = int.Parse(this.param["resolution"]);

            // 場所はConfigファイルを参照

            /**
             * 引数で指定すること
             * ・ファイル名（ファイルパスではない）
             * ・何倍の解像度にするか（省略で1倍？）
             * ・画像サイズ（width）？
             * ・画像サイズ（height）？
             */

            var filepath = this.gameManager.getConfig("screenshot_path") + filename + ".png";
            Application.CaptureScreenshot(filepath, resolution);

            var assembly = typeof(UnityEditor.EditorWindow).Assembly;
            var type = assembly.GetType("UnityEditor.GameView");

            var gameview = EditorWindow.GetWindow(type);

            // GameView再描画
            gameview.Repaint();



            //            this.gameView.messageArea.GetComponent<Text>().fontStyle = FontStyle.Italic;
            //this.gameView.messageArea.GetComponent<Text>().font = Font("TFPironv2");
            //変数に結果を格納
            //this.gameManager.startTag("[s]");

            //次のシナリオに進む処理
            //this.gameManager.nextOrder();
        }
    }
}
