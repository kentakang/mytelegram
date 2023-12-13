﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Info about a gifted Telegram Premium subscription
/// See <a href="https://corefork.telegram.org/constructor/messageActionGiftPremium" />
///</summary>
[TlObject(0xc83d6aec)]
public sealed class TMessageActionGiftPremium : IMessageAction
{
    public uint ConstructorId => 0xc83d6aec;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Three-letter ISO 4217 <a href="https://corefork.telegram.org/bots/payments#supported-currencies">currency</a> code
    ///</summary>
    public string Currency { get; set; }

    ///<summary>
    /// Price of the gift in the smallest units of the currency (integer, not float/double). For example, for a price of <code>US$ 1.45</code> pass <code>amount = 145</code>. See the exp parameter in <a href="https://corefork.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    ///</summary>
    public long Amount { get; set; }

    ///<summary>
    /// Duration of the gifted Telegram Premium subscription
    ///</summary>
    public int Months { get; set; }

    ///<summary>
    /// If the gift was bought using a cryptocurrency, the cryptocurrency name.
    ///</summary>
    public string? CryptoCurrency { get; set; }

    ///<summary>
    /// If the gift was bought using a cryptocurrency, price of the gift in the smallest units of a cryptocurrency.
    ///</summary>
    public long? CryptoAmount { get; set; }

    public void ComputeFlag()
    {
        if (CryptoCurrency != null) { Flags[0] = true; }
        if (/*CryptoAmount != 0 &&*/ CryptoAmount.HasValue) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Currency);
        writer.Write(Amount);
        writer.Write(Months);
        if (Flags[0]) { writer.Write(CryptoCurrency); }
        if (Flags[0]) { writer.Write(CryptoAmount.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Currency = reader.ReadString();
        Amount = reader.ReadInt64();
        Months = reader.ReadInt32();
        if (Flags[0]) { CryptoCurrency = reader.ReadString(); }
        if (Flags[0]) { CryptoAmount = reader.ReadInt64(); }
    }
}