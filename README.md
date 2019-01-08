# Fable minimal Service Worker sample

Creates two bundles, `app.js` and `sw.js`.

## Install

Add paket tool:

> dotnet tool install --tool-path ".paket" Paket --add-source https://api.nuget.org/v3/index.json

> .paket/paket restore
> yarn

## Build

> yarn webpack -p

## Develop

> yarn webpack-dev-server