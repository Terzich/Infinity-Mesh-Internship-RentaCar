


export interface BookedCar{
    id?:number;
    carID:number;
    userID:number;
    from:Date;
    to:Date;
    totalPrice:number;
    rating:number;
    comment:string;
    commentCreated:Date; 
} 