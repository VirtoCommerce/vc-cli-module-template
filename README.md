# Virto Commerce Module Templates for Dotnet New

This repository contains `dotnet new` templates for Virto Commerce Modules.

## Templates
* vc-module-dba-xapi - Creates a new Virto Commerce module with DB Agnostic and XAPI support.
* vc-module-dba - Creates a new Virto Commerce module with DB Agnostic support.
* vc-module-xapi - Creates a new Virto Commerce module with XAPI support.

## Getting Started

### Install

To get started, first install the templates:

```powershell
dotnet new install VirtoCommerce.Module.Template
```

### How to create a new module from template

* Open Windows PowerShell console
* Navigate to your sources folder
* Run one of the following commands depending on the type of module you want to create:

```powershell 
dotnet new vc-module-dba-xapi --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce
```

```powershell
dotnet new vc-module-dba --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce
```

```powershell
dotnet new vc-module-xapi --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce
```

where `--ModuleName` is your module name, `--Author` is your name, and `--CompanyName` is your company name.

* `vc-module-customer-reviews` folder with module solution will be created
* You can pass PlatformVersion attribute to create a new module for specific version of Virto Commerce.  

### Parameters description

| Options | Description | Type | Required | Default value |
|--------|-------------|------|----------|---------------|
| --Author (or -A) | Your name | string | Optional| John Doe |
| --CompanyName (or -C) | Your company name| string | Optional | VirtoCommerce |
| --ModuleName (or -M) | Your module name | string | Optional | NewModule |
| --ModuleVersion | Your module version | string | Optional | 3.800.0 |
| --PlatformVersion (or -P) | Virto Commerce platform version | string | Optional | 3.876.0 |
| --CoreVersion | Virto Commerce Core module version | string | Optional | 3.800.0 |
| --XapiVersion (or -X) | XAPI module version | string | Optional | 3.901.0 |

## How to uninstall

Run dotnet to uninstall templates

```powershell
dotnet new uninstall VirtoCommerce.Module.Template
```

## How to contribute

### Install templates locally

* Open Windows PowerShell console
* Clone repository

```powershell
git clone https://github.com/VirtoCommerce/vc-cli-module-template
```

* Install downloaded templates

```powershell
dotnet new install vc-cli-module-template\templates
```

### How to uninstall locally installed templates

* Run command

```powershell
dotnet new uninstall <full or relative path to the templates directory>
```

## License

Copyright (c) Virto Solutions LTD. All rights reserved.

Licensed under the Virto Commerce Open Software License (the "License"); you
may not use this file except in compliance with the License. You may
obtain a copy of the License at

[https://virtocommerce.com/open-source-license](https://virtocommerce.com/open-source-license)

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
implied.
