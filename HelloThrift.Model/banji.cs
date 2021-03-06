/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


#if !SILVERLIGHT
[Serializable]
#endif
public partial class banji : TBase
{

  public string BanjiName { get; set; }

  public List<student> AllStudents { get; set; }

  public banji() {
  }

  public banji(string banjiName, List<student> allStudents) : this() {
    this.BanjiName = banjiName;
    this.AllStudents = allStudents;
  }

  public void Read (TProtocol iprot)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_banjiName = false;
      bool isset_allStudents = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              BanjiName = iprot.ReadString();
              isset_banjiName = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                AllStudents = new List<student>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  student _elem2;
                  _elem2 = new student();
                  _elem2.Read(iprot);
                  AllStudents.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
              isset_allStudents = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_banjiName)
        throw new TProtocolException(TProtocolException.INVALID_DATA, "required field BanjiName not set");
      if (!isset_allStudents)
        throw new TProtocolException(TProtocolException.INVALID_DATA, "required field AllStudents not set");
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public void Write(TProtocol oprot) {
    oprot.IncrementRecursionDepth();
    try
    {
      TStruct struc = new TStruct("banji");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (BanjiName == null)
        throw new TProtocolException(TProtocolException.INVALID_DATA, "required field BanjiName not set");
      field.Name = "banjiName";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(BanjiName);
      oprot.WriteFieldEnd();
      if (AllStudents == null)
        throw new TProtocolException(TProtocolException.INVALID_DATA, "required field AllStudents not set");
      field.Name = "allStudents";
      field.Type = TType.List;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, AllStudents.Count));
        foreach (student _iter3 in AllStudents)
        {
          _iter3.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("banji(");
    __sb.Append(", BanjiName: ");
    __sb.Append(BanjiName);
    __sb.Append(", AllStudents: ");
    __sb.Append(AllStudents);
    __sb.Append(")");
    return __sb.ToString();
  }

}

