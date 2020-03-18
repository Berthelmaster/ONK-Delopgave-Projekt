<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete HaandVaerker</h3>
                    <form>
                        <v-text-field v-model="IdHaandvaerker" label="IdHaandvaerker"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete Vaerkstoejskasse</h3>
                    <form>
                        <v-text-field v-model="Id" label="Id"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete HaandVaerker</h3>
                    <form>
                        <v-text-field v-model="Id" label="Id"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
        </v-row>
    </v-container>
</template>

<script>
import axios from 'axios';
import { backendService } from '../variables'

export default {
     data: () => ({
      IdHaandvaerker: '',
    }),
    
methods: {
    submit(){
        console.log(this.IdHaandvaerker)
        axios.delete('http://' + backendService + '/api/Haandvaerkers/' + this.IdHaandvaerker)
    }
}
    }
</script>