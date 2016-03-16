# jokerscript-screenshot
jokerscriptでスクショを取るプラグイン

# 使い方
## プラグインのファイルを所定の位置に置く
`JOKER_GAME/Plugins/` 以下

[http://jokerscript.jp/adv/next/plugin](http://jokerscript.jp/adv/next/plugin)


## config.txtにパスを追加

```
screenshot_path="Assets/JOKER_GAME/Resources/novel/data/screenshots/"
screenshots という名前でディレクトリも追加しておく
```

## シナリオ内では
`[takess filename="（ファイル名）" resolution="1"]`

という感じで呼ぶ

# 用途想定
セーブ画面やロード画面でのスクリーンショット表示などに使ってください