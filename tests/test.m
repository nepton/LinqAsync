(* Mathematica Source File *)
(* Created by the Wolfram Language Plugin for IntelliJ, see http://wlplugin.halirutan.de/ *)
(* :Author: Nepton *)
(* :Date: 2022-10-20 *)

myPlot::err = "The first argument must be a list of numbers."
myPlot[data_List] := Module[{x, y, f, g},
  x = Range[Length[data]];
  y = data;
  f = Fit[x, y, x];
  g = Fit[x, y, x, x];
  Show[ListPlot[{x, y}, PlotStyle -> {Red, Blue}, PlotMarkers -> Automatic],
    Plot[f, {x, 1, Length[data]}],
    Plot[g, {x, 1, Length[data]}]]
]

myPlot[1, 2, 3]
