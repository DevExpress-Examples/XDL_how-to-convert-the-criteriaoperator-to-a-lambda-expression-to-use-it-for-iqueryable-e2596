# How to convert the CriteriaOperator to a lambda expression to use it for IQueryable


<p>Imagine, that an end-user can build a filter criteria, e.g. by using the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsFilterControltopic"><u>FilterControl</u></a>, and you wish to apply this filter criteria to your <strong>IQueryable </strong>source.</p>
<p>The static <strong>DevExpress.Data.Linq.Helpers.CriteriaToQueryableExtender</strong> class allows you to add extended methods for the <strong>IQueryable </strong>source, such as <strong>AppendWhere </strong>method, for example. This method provides a capability to create a new <strong>IQueryable </strong>source, based upon the existing one, and add an additional <strong>Where </strong>condition to it. So, you can convert the <strong>CriteriaOperator </strong>to the corresponding <strong>lambda </strong><strong>expression </strong>without any problem.</p>
<p>To extend the <strong>IQueryable </strong>source, it is sufficient to add the <strong>DevExpress.Data.Linq.Helpers namespace</strong>.</p>
<p>Please note that the DevExpress.Data.Linq.Helpers.CriteriaToQueryableExtender is an inner class, and we cannot guarantee that it will not be changed in the future.</p>

<br/>


