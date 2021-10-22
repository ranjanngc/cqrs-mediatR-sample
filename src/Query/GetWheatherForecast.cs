using System.Collections.Generic;
using MediatR;

namespace cqrs_mediatr{
    public class GetWhatherForecast: IRequest<IEnumerable<WeatherForecast>>
    {

    }
}