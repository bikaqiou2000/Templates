﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1739, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItemList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.ParameterizedSQL
    <Serializable()> _
    Public Partial Class LineItemList 
        Inherits BusinessListBase(Of LineItemList, LineItem)
    
        #Region "Contructor(s)"
        
        Private Sub New()
            AllowNew = true
        End Sub
    
        #End Region
    
        #Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Object
            Dim item As LineItem = PetShop.Tests.ParameterizedSQL.LineItem.NewLineItem()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.ParameterizedSQL.LineItem.NewLineItem()
                End If
            ' Pass the parent value down to the child.
                Dim order As Order = CType(Me.Parent, Order)
                If Not(order Is Nothing)
                    item.OrderId = order.OrderId
                End If
                Add(item)
            End If
    
            Return item
        End Function
    
        #End Region
    
        #Region "Synchronous Factory Methods"
    
        Public Shared Function NewList() As LineItemList
            Return DataPortal.Create(Of LineItemList)()
        End Function
    
        Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItemList 
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
			criteria.LineNum = lineNum
    
            Return DataPortal.Fetch(Of LineItemList)(criteria)
        End Function
    
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As LineItemList 
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of LineItemList)(criteria)
        End Function
    
        Public Shared Function GetAll() As LineItemList
            Return DataPortal.Fetch(Of LineItemList)(New LineItemCriteria())
        End Function
    
        #End Region
    
    
        #Region "Exists Command"
    
        Public Shared Function Exists(ByVal criteria As LineItemCriteria) As Boolean
            Return PetShop.Tests.ParameterizedSQL.LineItem.Exists(criteria)
        End Function
    
        #End Region
    
    
        #Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByVal item As LineItem, ByRef cancel As Boolean)
        End Sub
    
        #End Region
    End Class
End Namespace