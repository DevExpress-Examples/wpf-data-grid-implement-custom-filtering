# How to implement custom filtering


<p>This example demonstrates how to implement custom filtering in the DXGrid control.</p>


<h3>Description</h3>

<p>To do this, handle the <strong>GridControl.CustomRowFilter</strong> event, decide whether the current row should be filtered and assign the result to the <strong>e.Visible</strong> property. Also, set the <strong>e.Handled</strong> property to <strong>True</strong>.</p>

<br/>


