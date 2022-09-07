namespace SimpleApi.Data.Converter.Contract
{
    public interface IParser<O, D>
    {
        D Parse(O orign);
        List<D> Parse(List<O> orign);
    }
}
