// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::FlatBuffers;

public struct Rapunzel : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public Rapunzel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int HairLength { get { return __p.bb.GetInt(__p.bb_pos + 0); } }
  public void MutateHairLength(int hair_length) { __p.bb.PutInt(__p.bb_pos + 0, hair_length); }

  public static Offset<Rapunzel> CreateRapunzel(FlatBufferBuilder builder, int HairLength) {
    builder.Prep(4, 4);
    builder.PutInt(HairLength);
    return new Offset<Rapunzel>(builder.Offset);
  }
};

