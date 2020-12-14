# SManager
A **S**ystem**Manager** for CLI and GUI build on .NET 5 (previously known as .Net Core)
The CLI uses a customized version of [EasyConsole](https://github.com/MzB-Solutions/EasyConsole) to display menus  
This software aims to be as much an actual system tool as much as showcasing some common programming techniques and patterns

## Build Status
We are using [Github Actions](https://github.com/features/actions) to build the software, as well as running code quality and coverage checks.  
Please check out our workflow files under ```./.github/workflows/*.yaml``` to see how we used different actions and "plugins"

### Github Actions

| Workflow              |                                                   Build Status                                                  |
|-----------------------|:---------------------------------------------------------------------------------------------------------------:|
| .Net Core Build       | ![.NET Core build](https://github.com/MzB-Solutions/SystemT00ls/workflows/&period;NET%20Core%20build/badge.svg) |
| Code Coverage/Quality |  ![Code Quality](https://github.com/MzB-Solutions/SystemT00ls/workflows/Code%20Quality&sol;Coverage/badge.svg)  |

### Coveralls.io Status

| branch |                                                                                                                                                                                   |
|--------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| dev    |      [![Coverage Status (dev)](https://coveralls.io/repos/github/MzB-Solutions/SManager/badge.svg?branch=dev)](https://coveralls.io/github/MzB-Solutions/SManager?branch=dev)     |
| master | [![Coverage Status (master)](https://coveralls.io/repos/github/MzB-Solutions/SManager/badge.svg?branch=master)](https://coveralls.io/github/MzB-Solutions/SManager?branch=master) |