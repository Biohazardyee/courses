class Duree:
    def __init__(self, heures=0, minutes=1, secondes=0):
        # valeurs positives
        heures = abs(heures)
        minutes = abs(minutes)
        secondes = abs(secondes)

        # conversion secondes → minutes
        minutes += secondes // 60
        secondes = secondes % 60

        # conversion minutes → heures
        heures += minutes // 60
        minutes = minutes % 60

        # encapsulation (attributs privés)
        self.__heures = heures
        self.__minutes = minutes
        self.__secondes = secondes

    # Getters
    def get_heures(self):
        return self.__heures

    def get_minutes(self):
        return self.__minutes

    def get_secondes(self):
        return self.__secondes

    # Setters
    def set_heures(self, heures):
        self.__heures = abs(heures)

    def set_minutes(self, minutes):
        self.__heures += abs(minutes) // 60
        self.__minutes = abs(minutes) % 60

    def set_secondes(self, secondes):
        self.__minutes += abs(secondes) // 60
        self.__secondes = abs(secondes) % 60

    # Méthode d'affichage
    def afficher(self):
        print(f"{self.__heures}:{self.__minutes:02d}:{self.__secondes:02d}")

    # Retourne la durée en secondes
    def en_secondes(self):
        return self.__heures * 3600 + self.__minutes * 60 + self.__secondes

    # Ajoute un nombre de secondes
    def ajouter_secondes(self, s):
        total = self.en_secondes() + s
        if total < 0:
            total = abs(total)

        # recalcul h/m/s
        self.__heures = total // 3600
        total %= 3600
        self.__minutes = total // 60
        self.__secondes = total % 60
