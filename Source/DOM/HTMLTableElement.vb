﻿'''<Summary>The HTMLTableElement interface provides special properties and methods (beyond the regular HTMLElement object interface it also has available to it by inheritance) for manipulating the layout and presentation of tables in an HTML document.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [HTMLTableElement]
Inherits HTMLElement

  '''<Summary>Is a HTMLTableCaptionElement representing the first  element specifies the caption (or title) of a table.">&lt;caption&gt; that is a child of the element, or null if none is found. When set, if the object doesn't represent a &lt;caption&gt;, a DOMException with the HierarchyRequestError name is thrown. If a correct object is given, it is inserted in the tree as the first child of this element and the first &lt;caption&gt; that is a child of this element is removed from the tree, if any.</Summary>
  Property [caption] As HTMLElement
  '''<Summary>Is a HTMLTableSectionElement representing the first  element defines a set of rows defining the head of the columns of the table.">&lt;thead&gt; that is a child of the element, or null if none is found. When set, if the object doesn't represent a &lt;thead&gt;, a DOMException with the HierarchyRequestError name is thrown. If a correct object is given, it is inserted in the tree immediately before the first element that is neither a  element specifies the caption (or title) of a table.">&lt;caption&gt;, nor a  element defines a group of columns within a table.">&lt;colgroup&gt;, or as the last child if there is no such element, and the first &lt;thead&gt; that is a child of this element is removed from the tree, if any.</Summary>
  Property [tHead] As HTMLElement
  '''<Summary>Is a HTMLTableSectionElement representing the first  element defines a set of rows summarizing the columns of the table.">&lt;tfoot&gt; that is a child of the element, or null if none is found. When set, if the object doesn't represent a &lt;tfoot&gt;, a DOMException with the HierarchyRequestError name is thrown. If a correct object is given, it is inserted in the tree immediately before the first element that is neither a  element specifies the caption (or title) of a table.">&lt;caption&gt;, a  element defines a group of columns within a table.">&lt;colgroup&gt;, nor a  element defines a set of rows defining the head of the columns of the table.">&lt;thead&gt;, or as the last child if there is no such element, and the first &lt;tfoot&gt; that is a child of this element is removed from the tree, if any.</Summary>
  Property [tFoot] As HTMLElement
  '''<Summary>Returns a live HTMLCollection containing all the rows of the element, that is all  element defines a row of cells in a table. The row's cells can then be established using a mix of &lt;td> (data cell) and &lt;th> (header cell) elements.">&lt;tr&gt; that are a child of the element, or a child of one of its  element defines a set of rows defining the head of the columns of the table.">&lt;thead&gt;, ) encapsulates a set of table rows (&lt;tr> elements), indicating that they comprise the body of the table (&lt;table>).">&lt;tbody&gt; and  element defines a set of rows summarizing the columns of the table.">&lt;tfoot&gt; children. The rows members of a &lt;thead&gt; appear first, in tree order, and those members of a &lt;tbody&gt; last, also in tree order. The HTMLCollection is live and is automatically updated when the HTMLTableElement changes.</Summary>
  ReadOnly Property [rows] As HTMLCollection
  '''<Summary>Returns a live HTMLCollection containing all the ) encapsulates a set of table rows (&lt;tr> elements), indicating that they comprise the body of the table (&lt;table>).">&lt;tbody&gt; of the element. The HTMLCollection is live and is automatically updated when the HTMLTableElement changes.</Summary>
  ReadOnly Property [tBodies] As HTMLCollection
  '''<Summary>Returns an HTMLElement representing the first  element defines a set of rows defining the head of the columns of the table.">&lt;thead&gt; that is a child of the element. If none is found, a new one is created and inserted in the tree immediately before the first element that is neither a  element specifies the caption (or title) of a table.">&lt;caption&gt;, nor a  element defines a group of columns within a table.">&lt;colgroup&gt;, or as the last child if there is no such element.</Summary>
  Function [createTHead]() As HTMLTableSectionElement
  '''<Summary>Removes the first  element defines a set of rows defining the head of the columns of the table.">&lt;thead&gt; that is a child of the element.</Summary>
  Function [deleteTHead]() As HTMLElement
  '''<Summary>Returns an HTMLElement representing the first  element defines a set of rows summarizing the columns of the table.">&lt;tfoot&gt; that is a child of the element. If none is found, a new one is created and inserted in the tree immediately before the first element that is neither a  element specifies the caption (or title) of a table.">&lt;caption&gt;, a  element defines a group of columns within a table.">&lt;colgroup&gt;, nor a  element defines a set of rows defining the head of the columns of the table.">&lt;thead&gt;, or as the last child if there is no such element.</Summary>
  Function [createTFoot]() As HTMLTableSectionElement
  '''<Summary>Removes the first  element defines a set of rows summarizing the columns of the table.">&lt;tfoot&gt; that is a child of the element.</Summary>
  Function [deleteTFoot]() As HTMLElement
  '''<Summary>Returns an HTMLElement representing the first  element specifies the caption (or title) of a table.">&lt;caption&gt; that is a child of the element. If none is found, a new one is created and inserted in the tree as the first child of the  element represents tabular data — that is, information presented in a two-dimensional table comprised of rows and columns of cells containing data.">&lt;table&gt; element.</Summary>
  Function [createCaption]() As HTMLTableCaptionElement
  '''<Summary>Removes the first  element specifies the caption (or title) of a table.">&lt;caption&gt; that is a child of the element.</Summary>
  Function [deleteCaption]() As HTMLElement
  '''<Summary>Returns an HTMLTableRowElement representing a new row of the table. It inserts it in the rows collection immediately before the  element defines a row of cells in a table. The row's cells can then be established using a mix of &lt;td> (data cell) and &lt;th> (header cell) elements.">&lt;tr&gt; element at the given index position. If necessary a ) encapsulates a set of table rows (&lt;tr> elements), indicating that they comprise the body of the table (&lt;table>).">&lt;tbody&gt; is created. If the index is -1, the new row is appended to the collection. If the index is smaller than -1 or greater than the number of rows in the collection, a DOMException with the value IndexSizeError is raised.</Summary>
  Function [insertRow]([parindex] As Dynamic) As HTMLElement
  '''<Summary>Removes the row corresponding to the index given in parameter. If the index value is -1 the last row is removed; if it smaller than -1 or greater than the amount of rows in the collection, a DOMException with the value IndexSizeError is raised.</Summary>
  Function [deleteRow]([parindex] As Dynamic) As Integer
End Interface