# vc-module-template

`dotnet new` cli VirtoCommerce module template

## How to install template from NuGet repository

* Run command

```dos
dotnet new --install VirtoCommerce.Module.Template::1.0.0-alpha.7
```

## How to create a new module from template

* Open Windows PowerShell CMD
* Navigate to your sources folder
* Run command

```dos
dotnet new vc-module --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce --PlatformVersion "3.84.0" --PlatformNuGetPackageVersion "3.84.0"
```

where --ModuleName your module name, --Author your name and --CompanyName your company name

* `vc-module-CustomerReviews` folder with module solution will be created
* PlatformVersion and PlatformNuGetPackageVersion parameters have "3.84.0" "3.84.0" default values respectively. You can skip these parameters if you use default versions


## Parameters description

| Options | Description | Type | Required | Default value |
|--------|-------------|------|----------|---------------|
| --Author (or -A) | Your name | string | Optional| John Doe |
| --CompanyName (or -C) | Your company name| string | Optional | VirtoCommerce |
| --ModuleName (or -M) | Your module name | string | Optional | newModule |
| --PlatformVersion (or -P) | Required Platform Version | string | Optional | 3.84.0 |
| --PlatformNuGetPackageVersion (or -Pl) | Required Platform NuGet Package Version | string | Optional | 3.84.0 |

## How to uninstall template installed from NuGet repository

* Run command

```dos
dotnet new -u VirtoCommerce.Module.Template
```

## How to contribute

### Install template locally

* Open Windows PowerShell CMD
* Clone repository

```dos
git clone https://github.com/VirtoCommerce/vc-cli-module-template
```

* Navigate to cloned repository

```dos
cd vc-cli-module-template
```

* Install downloaded template

```dos
dotnet new -i vc-module-template
```

### How to uninstall locally installed template

* Run command

```dos
dotnet new -i `full path to vc-module-template`
```
