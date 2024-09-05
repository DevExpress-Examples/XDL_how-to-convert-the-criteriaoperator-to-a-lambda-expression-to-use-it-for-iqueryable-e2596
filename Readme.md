<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582972/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2596)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication152/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication152/Form1.vb))
* [Products.cs](./CS/WindowsFormsApplication152/Products.cs) (VB: [Products.vb](./VB/WindowsFormsApplication152/Products.vb))
* [Program.cs](./CS/WindowsFormsApplication152/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication152/Program.vb))
<!-- default file list end -->
# How to Convert the CriteriaOperator to a Lambda Expression to Use It for IQueryable

## Scenario

Imagine, that an end-user can build a filter criteria, e.g. by using a Filter Control, and you wish to apply this filter criteria to your IQueryable source.

## Implementation Steps

The static DevExpress.Data.Linq.Helpers.CriteriaToQueryableExtender class allows you to add extended methods for the IQueryable source, such as **AppendWhere** method. This method provides a capability to create a new IQueryable source, based upon the existing one, and add an additional **Where** condition to it. To extend the IQueryable source, add the `DevExpress.Data.Linq.Helpers` namespace in the `using` directive (or `Imports` for VB.NET).

>**NOTE**: CriteriaToQueryableExtender, ICriteriaToExpressionConverter, CriteriaToExpressionConverterInternal, CriteriaToEFExpressionConverter and related APIs from the DevExpress.Data.Linq.Helpers namespace are internal and undocumented – please use them at your own risk:
>- We cannot guarantee backward compatibility and that these internal and undocumented APIs will remain unchanged in the future. We may not extend/evolve these internal and undocumented APIs.
>- We may not provide technical support for use of internal APIs – you may be asked to perform your own research.
>- We also do not guarantee that this approach will operate correctly with [Criteria Language Syntax](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax) dialects for XPO, XAF, Dashboards, and other products. If you clarify your business requirements for these products, we will be in a better position to find a more reasonable solution for you – one that does not require the use of internal/undocumented APIs.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XDL_how-to-convert-the-criteriaoperator-to-a-lambda-expression-to-use-it-for-iqueryable-e2596&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XDL_how-to-convert-the-criteriaoperator-to-a-lambda-expression-to-use-it-for-iqueryable-e2596&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
