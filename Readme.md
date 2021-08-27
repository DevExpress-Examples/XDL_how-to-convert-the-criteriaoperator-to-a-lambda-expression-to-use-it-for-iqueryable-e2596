<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582972/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2596)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication152/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication152/Form1.vb))
* [Products.cs](./CS/WindowsFormsApplication152/Products.cs) (VB: [Products.vb](./VB/WindowsFormsApplication152/Products.vb))
* [Program.cs](./CS/WindowsFormsApplication152/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication152/Program.vb))
<!-- default file list end -->
# How to convert the CriteriaOperator to a lambda expression to use it for IQueryable


<p>Imagine, that an end-user can build a filter criteria, e.g. by using the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsFilterControltopic"><u>FilterControl</u></a>, and you wish to apply this filter criteria to your <strong>IQueryable </strong>source.</p>
<p>The static <strong>DevExpress.Data.Linq.Helpers.CriteriaToQueryableExtender</strong> class allows you to add extended methods for the <strong>IQueryable </strong>source, such as <strong>AppendWhere </strong>method, for example. This method provides a capability to create a new <strong>IQueryable </strong>source, based upon the existing one, and add an additional <strong>Where </strong>condition to it. So, you can convert the <strong>CriteriaOperator </strong>to the corresponding <strong>lambda </strong><strong>expression </strong>without any problem.</p>
<p>To extend the <strong>IQueryable </strong>source, it is sufficient to add the <strong>DevExpress.Data.Linq.Helpers namespace</strong>.</p>
<p>Please note that the DevExpress.Data.Linq.Helpers.CriteriaToQueryableExtender is an inner class, and we cannot guarantee that it will not be changed in the future.</p>

<br/>


