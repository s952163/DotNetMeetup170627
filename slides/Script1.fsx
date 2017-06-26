type CardType = 
    | Visa
    | MasterCard
 
type CheckNumber = int

type CardNumber = string


type CreditCardInfo = { 
    CardType: CardType
    CardNumber: CardNumber
}

type PaymentMethod = 
    | Cash
    | Check of CheckNumber
    | Card of CreditCardInfo

let ccinfo = {CardType=Visa;CardNumber="09830984092"}

let payment = Card ccinfo