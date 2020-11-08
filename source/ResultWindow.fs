module ResultWindow

open System.Windows
open System

open CommonType

type ResultWindow(item: OmikujiData) =
    let window = Application.LoadComponent (Uri("/xaml/ResultWindow.xaml", UriKind.Relative)) :?> Window
    let _ = window.DataContext <- item

    member this.Window = window
