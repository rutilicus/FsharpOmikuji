module MainWindow

open System
open System.Windows
open System.Windows.Controls

open CommonType
open ResultWindow

type MainWindow(items: OmikujiData[]) =
    let window = Application.LoadComponent (Uri("/xaml/MainWindow.xaml", UriKind.Relative)) :?> Window
    let button = window.FindName "Omikuji" :?> Button
    let rand = Random()

    let _ = button.Click |> Event.add (fun _ -> 
                                        let resultWindow = ResultWindow(items.[rand.Next(items.Length)])
                                        let _ = resultWindow.Window.Show ()
                                        let _ = resultWindow.Window.Owner <- window
                                        ())

    member this.Window = window
