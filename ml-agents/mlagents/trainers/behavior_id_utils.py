from typing import Dict, NamedTuple


class BehaviorIdentifiers(NamedTuple):
    brain_name: str
    behavior_ids: Dict[str, int]

    @staticmethod
    def from_name_behavior_id(name_behavior_id: str) -> "BehaviorIdentifiers":
        """
        Parses a name_behavior_id into a BehaviorIdentifiers NamedTuple.
        This allows you to access the brain name and distinguishing identifiers
        without parsing more than once.
        :param name_behavior_id: String of behavior params in HTTP format.
        :returns: A BehaviorIdentifiers object.
        """

        ids: Dict[str, int] = {}
        if "?" in name_behavior_id:
            name, identifiers = name_behavior_id.split("?")
            if "&" in identifiers:
                list_of_identifiers = identifiers.split("&")
            else:
                list_of_identifiers = [identifiers]

            for identifier in list_of_identifiers:
                key, value = identifier.split("=")
                ids[key] = int(value)
        else:
            name = name_behavior_id

        return BehaviorIdentifiers(brain_name=name, behavior_ids=ids)
