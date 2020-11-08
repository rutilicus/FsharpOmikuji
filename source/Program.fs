open System
open System.Windows

open CommonType
open MainWindow

[<STAThread>]
[<EntryPoint>]
let main argv =
    let omikujiData = [| { Fortune = "大吉"; Message = "寝る子は育つ" }
                         { Fortune = "中吉"; Message = "よく遊びよく寝る" }
                         { Fortune = "吉"; Message = "三大欲求のひとつとされる睡眠欲" }
                         { Fortune = "小吉"; Message = "明日できることは明日やろう" }
                         { Fortune = "凶"; Message = "生きるのはつらい、今日は寝てすべて忘れよう" }
                       |]
    let window = MainWindow(omikujiData).Window
    let _ = Application().Run window
    0
