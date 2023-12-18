using Cspace.Services;

UserService userService = new UserService();
PlaceService placeService = new PlaceService();
FeatureService featureService = new FeatureService();
BookingService bookingService = new BookingService(placeService, userService);

