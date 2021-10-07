# vc-module-template

`dotnet new` cli VirtoCommerce module template

## How to install template locally

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

## How to create a new module from template

* Open Windows PowerShell CMD
* Navigate to your sources folder
* Run command

```dos
dotnet new vc-module --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce --PlatformVersion "3.62.0" --PlatformNuGetPackageVersion "3.62.0"
```

where --ModuleName your module name, --Author your name and --CompanyName your company name

* `vc-module-CustomerReviews` folder with module solution will be created
* PlatformVersion and PlatformNuGetPackageVersion parameters have "3.62.0" "3.62.0" default values respectively. You can skip these parameters if you use default versions

## How to uninstall locally installed template

* Run command

```dos
dotnet new -i `full path to vc-module-template`
```
