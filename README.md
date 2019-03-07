# Fable.ReactBodymovin

Fable bindings for [react-bodymovin](https://www.npmjs.com/package/react-bodymovin), a very simple React wrapper for
[bodymovin](https://github.com/bodymovin/bodymovin).

### Nuget Packages

Stable | Prerelease
--- | ---
[![NuGet Badge](https://buildstats.info/nuget/Fable.ReactBodymovin)](https://www.nuget.org/packages/Fable.ReactBodymovin/) | [![NuGet Badge](https://buildstats.info/nuget/Fable.ReactBodymovin?includePreReleases=true)](https://www.nuget.org/packages/Fable.ReactBodymovin/)


## Example

```
module Example

open Fable.ReactBodymovin

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.ReactBodymovin


// Import the SVG animation as a POJO
[<Import("default", from="../../Static/assets/lottie_animation.json")>]
let private animationData: obj = jsNative

/// Render the loading animnation using the Lottie/bodymovin Javascript library.
let svgAnimation () =
    let options : BodymovinOptions =
        { loop = true
          autoplay = true
          prerender = true
          animationData = animationData }
    bodymovinAnimation options
```


## Development

### Building

Make sure the following **requirements** are installed in your system:

* [dotnet SDK](https://www.microsoft.com/net/download/core) 2.0 or higher
* [node.js](https://nodejs.org) 6.11 or higher
* [yarn](https://yarnpkg.com)
* [Mono](http://www.mono-project.com/) if you're on Linux or macOS.

Then you just need to type `./build.cmd` or `./build.sh`

### Release

In order to push the package to [nuget.org](https://nuget.org) you need to add your API keys to `NUGET_KEY` environmental variable.
You can create a key [here](https://www.nuget.org/account/ApiKeys).

- Update RELEASE_NOTES with a new version, data and release notes [ReleaseNotesHelper](http://fake.build/apidocs/fake-releasenoteshelper.html).
Ex:

```
#### 0.2.0 - 30.04.2017
* FEATURE: Does cool stuff!
* BUGFIX: Fixes that silly oversight
```

- You can then use the Release target. This will:
  - make a commit bumping the version: Bump version to 0.2.0
  - publish the package to nuget
  - push a git tag

`./build.sh Release`
