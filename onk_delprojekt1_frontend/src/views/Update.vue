<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Update HaandVaerker</h3>
                    <form>
                        <v-text-field v-model="Id" label="Id"></v-text-field>
                        <v-text-field v-model="HVFornavn" label="First name"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Update Vaerkstoejskasse</h3>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Update HaandVaerker</h3>
                </div>
        </v-row>
    </v-container>
</template>

<script>
import axios from 'axios';
import { backendService } from '../variables'


export default {

    
    data: () => ({
      Id: '',
      HVFornavn: '',

      haandvaerker: ''

    }),

    methods: {
    submit(){
        console.log(this.IdHaandvaerker)
        console.log(this.HVFornavn)
        axios.put('http://' + backendService + '/api/Haandvaerkers/' + this.Id, {
            HaandvaerkerId: Number(this.Id),
            HVFornavn: this.HVFornavn,
            HVFagomraade: "Fodboldspiller",
            HVEfternavn: "Stage"
        })
    }
}
}
</script>