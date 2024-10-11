#### 概要
* ASP.Net.Core + MySql + DockerによるWebAPI開発環境
* debug実行を行うための習作

#### 実行
* Visual Studioでapi-docker-study-01.slnを起動
* ソリューション構成 `Debug` にて `Docker Compose` 実行 (起動時設定がこうなってるはず)
* 初回実行時はswaggerからmigrationを実行する

#### その他
* 要Docker Desktop
* 初回migration時、MySqlデータのダウンロードが完了していない場合にエラーが発生しうる
* mysql/data直下にDBデータの実体が作成される
