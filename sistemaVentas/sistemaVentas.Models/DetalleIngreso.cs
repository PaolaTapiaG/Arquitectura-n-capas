using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DetalleIngreso
{
    public int IdDetalleIngreso { get; set; }
    public int IdProducto { get; set; }
    public int IdIngreso { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioCosto { get; set; }
    public decimal PrecioVenta { get; set; }
    public decimal Subtotal { get; set; }
    public string Estado { get; set; }
}