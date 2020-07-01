﻿'''<Summary>The WebRTC API's RTCIceCandidateInit dictionary, which contains the information needed to fundamentally describe an RTCIceCandidate.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [RTCIceCandidateInit]
  '''<Summary>The ICE candidate-attribute. If the candidate is an indicator that there are no further candidates (rather than representing a new candidate), this is the empty string (""). The default is the empty string.</Summary>
  Property [candidate] As String
  '''<Summary>The identification tag of the media stream with which the candidate is associated, or null if there is no associated media stream. The default is null.</Summary>
  Property [sdpMid] As Integer
  '''<Summary>The zero-based index of the m-line within the SDP of the media description with which the candidate is associated, or null if no such associated exists. The default is null.</Summary>
  Property [sdpMLineIndex] As Integer
  '''<Summary>A DOMString containing a string which uniquely identifies the remote peer. This string is generated by WebRTC at the beginning of the session, and at least 24 bits worth of the string contain random data. The string may be up to 256 characters long. This property has no default value and is not present unless set explicitly.</Summary>
  Property [usernameFragment] As String
End Interface