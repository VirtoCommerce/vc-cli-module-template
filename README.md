# Virto Commerce module templates

`dotnet new` CLI Virto Commerce module templates

## How to install templates from NuGet repository

* Run command

```PowerShell
dotnet new --install VirtoCommerce.Module.Template
```

## How to create a new module from template

* Open Windows PowerShell CMD
* Navigate to your sources folder
* Run command

```PowerShell
dotnet new vc-module --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce --PlatformVersion "3.253.1"
```

where `--ModuleName` is your module name, `--Author` is your name, and `--CompanyName` is your company name

* `vc-module-customer-reviews` folder with module solution will be created
* PlatformVersion parameter has "3.253.1" value by default. You can skip this parameter if you use default version

## How to create a new XAPI module from template
There is a seprate template named `vc-module-xapi` for an XAPI module.

* Open Windows PowerShell CMD
* Navigate to your sources folder
* Run command

```PowerShell
dotnet new vc-module-xapi --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce --PlatformVersion "3.253.1"
```

## Parameters description

| Options | Description | Type | Required | Default value |
|--------|-------------|------|----------|---------------|
| --Author (or -A) | Your name | string | Optional| John Doe |
| --CompanyName (or -C) | Your company name| string | Optional | VirtoCommerce |
| --ModuleName (or -M) | Your module name | string | Optional | newModule |
| --PlatformVersion (or -P) | Virto Commerce platform version | string | Optional | 3.253.1 |

## How to uninstall templates installed from NuGet repository

* Run command

```PowerShell
dotnet new -u VirtoCommerce.Module.Template
```

## How to contribute

### Install templates locally

* Open Windows PowerShell CMD
* Clone repository

```PowerShell
git clone https://github.com/VirtoCommerce/vc-cli-module-template
```

* Install downloaded templates

```PowerShell
dotnet new -i vc-cli-module-template\templates
```

### How to uninstall locally installed templates

* Run command

```PowerShell
dotnet new -u <full or relative path to the templates directory>
```
