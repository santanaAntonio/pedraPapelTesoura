import { axiosInstance } from "../_base/axiosInstance";

export function useMatch() {

    async function match(PlayerBet) {
        try {
            const response = await axiosInstance.post(
                `/match`,{
                    PlayerBet: PlayerBet,
                }
            );
            return response.data;
        } catch (error) {
            console.log(error.message);
        }
    }

    return {
        match
    };
}
