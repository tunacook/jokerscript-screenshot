using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

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

            var filepath = this.gameManager.getConfig("screenshot_path") + filename + ".png";
            Application.CaptureScreenshot(filepath, resolution);

            var assembly = typeof(UnityEditor.EditorWindow).Assembly;
            var type = assembly.GetType("UnityEditor.GameView");

            var gameview = EditorWindow.GetWindow(type);

            // GameView再描画
            gameview.Repaint();
        }
    }
}
