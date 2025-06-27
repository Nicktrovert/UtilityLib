using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.UData.UDistance;

//mm - cm - dm - m - km - Mm - Gm

public partial struct UDistance
{
    private decimal _distance; //m

    public UDistance(decimal distance)
    {
        _distance = distance;
    }

    public readonly decimal MiliMeter => _distance * (10 ^ -9);
    public readonly decimal CentiMeter => _distance * (10 ^ -6);
    public readonly decimal DeciMeter => _distance * (10 ^ -3);
    public readonly decimal Meter => _distance * (10 ^ 0);
    public readonly decimal KiloMeter => _distance * (10 ^ 3);
    public readonly decimal MegaMeter => _distance * (10 ^ 6);
    public readonly decimal GigaMeter => _distance * (10 ^ 9);

    public void AddDistance(UDistance uDistance) => this._distance = this._distance + uDistance.Meter;
    public void AddDistance(decimal distance) => this._distance = this._distance + distance;
    public void AddDistance(float distance) => this._distance = this._distance + (decimal)distance;
    public void AddDistance(double distance) => this._distance = this._distance + (decimal)distance;
    public void AddDistance(int distance) => this._distance = this._distance + distance;

    public void SubtractDistance(UDistance uDistance) => this._distance = this._distance - uDistance.Meter;
    public void SubtractDistance(decimal distance) => this._distance = this._distance - distance;
    public void SubtractDistance(float distance) => this._distance = this._distance - (decimal)distance;
    public void SubtractDistance(double distance) => this._distance = this._distance - (decimal)distance;
    public void SubtractDistance(int distance) => this._distance = this._distance - distance;
}
