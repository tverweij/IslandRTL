﻿'''<Summary>The DOM Node interface is a key base class upon which many other DOM API objects are based, thus letting those object types to be used similarly and often interchangeably.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [Node]
Inherits EventTarget

  '''<Summary>Returns a DOMString representing the base URL of the document containing the Node.</Summary>
  ReadOnly Property [baseURI] As String
  '''<Summary>Returns a live NodeList containing all the children of this node. NodeList being live means that if the children of the Node change, the NodeList object is automatically updated.</Summary>
  ReadOnly Property [childNodes] As Node
  '''<Summary>Returns a Node representing the first direct child node of the node, or null if the node has no child.</Summary>
  ReadOnly Property [firstChild] As Node
  '''<Summary>A boolean indicating whether or not the Node is connected (directly or indirectly) to the context object, e.g. the Document object in the case of the normal DOM, or the ShadowRoot in the case of a shadow DOM.</Summary>
  ReadOnly Property [isConnected] As Boolean
  '''<Summary>Returns a Node representing the last direct child node of the node, or null if the node has no child.</Summary>
  ReadOnly Property [lastChild] As Node
  '''<Summary>Returns a Node representing the next node in the tree, or null if there isn't such node.</Summary>
  ReadOnly Property [nextSibling] As Node
  '''<Summary>Returns a DOMString containing the name of the Node. The structure of the name will differ with the node type. E.g. An HTMLElement will contain the name of the corresponding tag, like 'audio' for an HTMLAudioElement, a Text node will have the '#text' string, or a Document node will have the '#document' string.</Summary>
  ReadOnly Property [nodeName] As Node
  '''<Summary>Returns / Sets the value of the current node.</Summary>
  Property [nodeValue] As Node
  '''<Summary>Returns the Document that this node belongs to. If the node is itself a document, returns null.</Summary>
  ReadOnly Property [ownerDocument] As Document
  '''<Summary>Returns a Node that is the parent of this node. If there is no such node, like if this node is the top of the tree or if doesn't participate in a tree, this property returns null.</Summary>
  ReadOnly Property [parentNode] As Node
  '''<Summary>Returns an Element that is the parent of this node. If the node has no parent, or if that parent is not an Element, this property returns null.</Summary>
  ReadOnly Property [parentElement] As Element
  '''<Summary>Returns a Node representing the previous node in the tree, or null if there isn't such node.</Summary>
  ReadOnly Property [previousSibling] As Node
  '''<Summary>Returns / Sets the textual content of an element and all its descendants.</Summary>
  Property [textContent] As String
End Interface