﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1739, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Validation
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Tests.StoredProcedures
    <Serializable()> _
    Public Partial Class LineItem 
        Inherits BusinessBase(Of LineItem)
    
        #Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method 
        End Sub
    
        Friend Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            Using(BypassPropertyChecks)
                _orderId = orderId
                _lineNum = lineNum
            End Using
        End Sub
    
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
        End Sub
        #End Region    
    
        #Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _itemIdProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10))
        End Sub
    
        #End Region
    
        #Region "Properties"
    
    
        Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OrderId, String.Empty)
        Private _orderId As System.Int32 = _orderIdProperty.DefaultValue
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property OrderId() As System.Int32
            Get 
                Return GetProperty(_orderIdProperty, _orderId) 
            End Get
            Set (value As System.Int32)
                SetProperty(_orderIdProperty, _orderId, value)
            End Set
        End Property
    
        Private Shared ReadOnly _originalOrderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OriginalOrderId, String.Empty)
        Private _originalOrderId As System.Int32 = _originalOrderIdProperty.DefaultValue
        ''' <summary>
        ''' Holds the original value for OrderId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalOrderId() As System.Int32
            Get 
                Return GetProperty(_originalOrderIdProperty, _originalOrderId) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalOrderIdProperty, _originalOrderId, value)
            End Set
        End Property
        
    
        Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.LineNum, String.Empty)
        Private _lineNum As System.Int32 = _lineNumProperty.DefaultValue
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property LineNum() As System.Int32
            Get 
                Return GetProperty(_lineNumProperty, _lineNum) 
            End Get
            Set (value As System.Int32)
                SetProperty(_lineNumProperty, _lineNum, value)
            End Set
        End Property
    
        Private Shared ReadOnly _originalLineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OriginalLineNum, String.Empty)
        Private _originalLineNum As System.Int32 = _originalLineNumProperty.DefaultValue
        ''' <summary>
        ''' Holds the original value for LineNum. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalLineNum() As System.Int32
            Get 
                Return GetProperty(_originalLineNumProperty, _originalLineNum) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalLineNumProperty, _originalLineNum, value)
            End Set
        End Property
        
    
        Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As LineItem) p.ItemId, String.Empty)
        Private _itemId As System.String = _itemIdProperty.DefaultValue
        
        Public Property ItemId() As System.String
            Get 
                Return GetProperty(_itemIdProperty, _itemId) 
            End Get
            Set (value As System.String)
                SetProperty(_itemIdProperty, _itemId, value)
            End Set
        End Property
        
    
        Private Shared ReadOnly _quantityProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.Quantity, String.Empty)
        Private _quantity As System.Int32 = _quantityProperty.DefaultValue
        
        Public Property Quantity() As System.Int32
            Get 
                Return GetProperty(_quantityProperty, _quantity) 
            End Get
            Set (value As System.Int32)
                SetProperty(_quantityProperty, _quantity, value)
            End Set
        End Property
        
    
        Private Shared ReadOnly _unitPriceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As LineItem) p.UnitPrice, String.Empty)
        Private _unitPrice As System.Decimal = _unitPriceProperty.DefaultValue
        
        Public Property UnitPrice() As System.Decimal
            Get 
                Return GetProperty(_unitPriceProperty, _unitPrice) 
            End Get
            Set (value As System.Decimal)
                SetProperty(_unitPriceProperty, _unitPrice, value)
            End Set
        End Property
        
    
    
        'AssociatedManyToOne
        Private Shared ReadOnly _orderMemberProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As LineItem) p.OrderMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property OrderMember() As Order
            Get
                If Not(FieldManager.FieldExists(_orderMemberProperty))
                    Dim criteria As New PetShop.Tests.StoredProcedures.OrderCriteria()
                    criteria.OrderId = OrderId
    
                    If (Me.IsNew Or Not PetShop.Tests.StoredProcedures.Order.Exists(criteria)) Then
                        LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.NewOrder())
                    Else
                        LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.GetByOrderId(OrderId))
                    End If
                End If
                
                Return GetProperty(_orderMemberProperty) 
            End Get
        End Property
        
        #End Region
    
        #Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewLineItem() As LineItem 
            Return DataPortal.Create(Of LineItem)()
        End Function
    
        Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
			criteria.LineNum = lineNum
    
            Return DataPortal.Fetch(Of LineItem)(criteria)
        End Function
    
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of LineItem)(criteria)
        End Function
    
        Public Shared Sub DeleteLineItem(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            DataPortal.Delete(Of LineItem)(New LineItemCriteria (orderId, lineNum))
        End Sub
    
        #End Region
    
        #Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewLineItemChild() As LineItem
            Return DataPortal.CreateChild(Of LineItem)()
        End Function
    
        Friend Shared Function GetByOrderIdLineNumChild(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            Return DataPortal.FetchChild(Of LineItem)(criteria)
        End Function
    
        Friend Shared Function GetByOrderIdChild(ByVal orderId As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.FetchChild(Of LineItem)(criteria)
        End Function
    
        #End Region
    
    
        #Region "Exists Command"
    
        Public Shared Function Exists(ByVal criteria As LineItemCriteria ) As Boolean
            Return ExistsCommand.Execute(criteria)
        End Function
    
        #End Region
    
    
        #Region "Protected Overriden Method(s)"
        
        ' NOTE: This is needed for Composite Keys. 
        Private ReadOnly _guidID As Guid = Guid.NewGuid()
        Protected Overrides Function GetIdValue() As Object
            Return _guidID
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
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnInserted()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
    
        #End Region
    
        #Region "ChildPortal partial methods"
    
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
    
        #End Region
    End Class
End Namespace