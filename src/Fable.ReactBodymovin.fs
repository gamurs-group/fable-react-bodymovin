/// <summary>
/// Fable bindings for the npm 'react-bodymovin' package.
///
/// For details see:http://airbnb.io/lottie/web/web.html
/// </summary>
///
/// <example>
/// <code>
///     module MyViewComponent
///
///     open GamerAI.Web.Client.Import
///
///     [<Import("default", from="../../Static/assets/brand/GamerAI-Loading_Icon_V2.json")>]
///     let private animationData: obj = jsNative
///
///     let svgAnimation =
///         let options : Bodymovin.Options =
///             { loop = true
///               autoplay = true
///               prerender = true
///               animationData = animationData }
///         Bodymovin.svgAnimation options
/// </code>
/// </example>
module Fable.ReactBodymovin

open Fable.Helpers.React
open Fable.Import.React

/// Options accepted by the ReactBodymovin component.
type BodymovinOptions =
  { loop : bool
    autoplay : bool
    prerender : bool
    animationData : obj }

/// Props accepted by the ReactBodymovin component.
type private BodymovinProps =
  { options : BodymovinOptions }

/// <summary>
/// Render the SVG animation as a react component.
/// </summary>
///
/// <param name="options">
/// Animation options.
/// </param>
let bodymovinAnimation (options : BodymovinOptions) : ReactElement =
    let props = { options = options }
    ofImport "default" "react-bodymovin" props []
