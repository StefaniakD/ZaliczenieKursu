namespace RodWpf
{
    class EnergyCounter
    {
        public int Add(string energyCounterNumber, string mountDate, string validDate, int roomId)
        {
            DatabaseConnection db = new DatabaseConnection();
            Rooms room = new Rooms();
            
            int counterId = db.QueryInsert("INSERT INTO energyCounters (energyCounterNumber, mountDate, validDate) OUTPUT inserted.energyCounterId VALUES ('"+energyCounterNumber+"','"+mountDate+"','"+validDate+"');");
            room.AssignEnergyCounterToRoom(roomId, counterId);

            return counterId;
        }

    }
}
