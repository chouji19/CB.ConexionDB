namespace CB.ConexionDB {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CuentasReq", @"CuentasResp"})]
    public sealed class InserttbCuentaService_v1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""htttp://EsquemaCuentas/v1"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""htttp://EsquemaCuentas/v1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CuentasReq"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:updategram=""urn:schemas-microsoft-com:xml-updategram"" updategram:Prefix=""updg"" minOccurs=""1"" maxOccurs=""unbounded"" name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element updategram:Prefix=""updg"" minOccurs=""0"" maxOccurs=""unbounded"" name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""tbCuenta"">
                      <xs:complexType>
                        <xs:attribute name=""NombreCliente"" type=""xs:string"" />
                        <xs:attribute name=""TipoCuenta"" type=""xs:string"" />
                        <xs:attribute name=""NumeroCuenta"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CuentasResp"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InserttbCuentaService_v1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "CuentasReq";
                _RootElements[1] = "CuentasResp";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"htttp://EsquemaCuentas/v1",@"CuentasReq")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CuentasReq"})]
        public sealed class CuentasReq : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CuentasReq() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CuentasReq";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"htttp://EsquemaCuentas/v1",@"CuentasResp")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CuentasResp"})]
        public sealed class CuentasResp : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CuentasResp() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CuentasResp";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
